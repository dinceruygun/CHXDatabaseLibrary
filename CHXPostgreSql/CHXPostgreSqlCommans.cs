using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;
using CHXDatabase.IO.DatabaseFeatures;
using CHXGeoJson;

namespace CHXPostgreSqlLibrary
{
    public class CHXPostgreSqlCommans: ICHXDatabaseCommand
    {
        public CHXPostgreSqlCommans(CHXDatabase.IO.CHXDatabase database) : base(database)
        {

        }

        protected void Init()
        {

        }


        public override CHXQuery GetAllTable()
        {
            return new CHXQuery("select schemaname as schemaname, tablename as tablename, tableowner as ownername from pg_catalog.pg_tables;");
        }

        public override CHXQuery GetColumns(string schemaName, string tableName)
        {
            return new CHXQuery(@"select column_name as ColumnName, column_default as DefaultValue, is_nullable as IsNullable, data_type as DataType, 
                                    character_maximum_length as MaximumLength from information_schema.columns where table_schema = @SCHEMANAME AND table_name   = @TABLENAME",
                                    new { SCHEMANAME = schemaName, TABLENAME = tableName });
        }

        public override CHXQuery GetAllGeometryColumns()
        {
            return new CHXQuery("select f_table_catalog as CatalogName, f_table_schema as SchemaName, f_table_name as TableName, f_geometry_column as  Name, srid as Srid, type as GeometryType from geometry_columns;");
        }

        public override CHXQuery GetAllView()
        {
            return new CHXQuery("select table_catalog, table_schema as schemaname, table_name as tablename from INFORMATION_SCHEMA.views;");
        }

        public override CHXQuery GetAllSequence()
        {
            return new CHXQuery(@"select seq.sequence_schema as schemaname, seq_relation.related_table as tablename, seq_relation.related_column as columnname, seq.sequence_name as sequencename,
	                                seq.maximum_value as maximumvalue, seq.minimum_value as minimumvalue, seq.increment, seq.start_value as startvalue
	                                from(
                                SELECT t.relname as related_table, 
                                       a.attname as related_column,
                                       s.relname as sequence_name,
                                       s.relkind,
                                       n.nspname
                                FROM pg_class s 
                                  JOIN pg_depend d ON d.objid = s.oid 
                                  JOIN pg_class t ON d.objid = s.oid AND d.refobjid = t.oid 
                                  JOIN pg_attribute a ON (d.refobjid, d.refobjsubid) = (a.attrelid, a.attnum)
                                  JOIN pg_namespace n ON n.oid = s.relnamespace 
                                WHERE s.relkind     = 'S' ) as seq_relation
                                right join information_schema.sequences as seq on seq_relation.sequence_name =  seq.sequence_name   and seq_relation.nspname = seq.sequence_schema");
        }

        public override CHXQuery GetSequence(string sequenceName)
        {
            return new CHXQuery($"select sequence_name as SequenceName, last_value as CurrentValue, start_value as StartValue from {sequenceName}");
        }

        public override CHXQuery GetAllConstraint()
        {
            return new CHXQuery(@"select contype::text as exdata1, nspname as SchemaName, (conrelid::regclass)::text AS TableName, conname as constraintName, pg_get_constraintdef(c.oid) as constraintValue
                                from   pg_constraint c
                                join   pg_namespace n ON n.oid = c.connamespace
                                where  contype in ('f', 'p','c','u') order by contype");
        }

        public override CHXConstraintType GetConstraintType(CHXConstraint constraint)
        {
            if (constraint.exdata1 == "c")
            {
                return CHXConstraintType.Check;
            }
            else if (constraint.exdata1 == "f")
            {
                return CHXConstraintType.Foreignkey;
            }
            else if (constraint.exdata1 == "p")
            {
                return CHXConstraintType.Primarykey;
            }
            else if (constraint.exdata1 == "u")
            {
                return CHXConstraintType.Unique;
            }
            else
            {
                return CHXConstraintType.Check;
            }
        }

        public override CHXQuery GetAllIndex()
        {
            return new CHXQuery(@"SELECT
                                     n.nspname  as SchemaName
                                    ,t.relname  as TableName
                                    ,c.relname  as IndexName
                                    ,i.indisunique AS IsUnique
                                    ,array_to_string(array_agg(a.attname), ', ') as ColumnName
                                    ,pg_get_indexdef(i.indexrelid) as ddl
                                FROM pg_catalog.pg_class c
                                    JOIN pg_catalog.pg_namespace n ON n.oid = c.relnamespace
                                    JOIN pg_catalog.pg_index i ON i.indexrelid = c.oid
                                    JOIN pg_catalog.pg_class t ON i.indrelid = t.oid
                                    JOIN pg_attribute a ON a.attrelid = t.oid AND a.attnum = ANY(i.indkey)
                                WHERE c.relkind = 'i'
                                      and n.nspname not in ('pg_catalog', 'pg_toast')
                                      and pg_catalog.pg_table_is_visible(c.oid)
                                GROUP BY
                                    n.nspname
                                    ,t.relname
                                    ,c.relname
                                    ,i.indisunique
                                    ,i.indexrelid
                                ORDER BY
                                    n.nspname
                                    ,t.relname
                                    ,c.relname; ");
        }

        public override CHXQuery GetDependsTableList(string schemaName, string tableName)
        {
            return new CHXQuery(@"SELECT dependent_ns.nspname as SchemaName
                                , dependent_view.relname as TableName 
                                FROM pg_depend 
                                JOIN pg_rewrite ON pg_depend.objid = pg_rewrite.oid 
                                JOIN pg_class as dependent_view ON pg_rewrite.ev_class = dependent_view.oid 
                                JOIN pg_class as source_table ON pg_depend.refobjid = source_table.oid 
                                JOIN pg_attribute ON pg_depend.refobjid = pg_attribute.attrelid 
                                    AND pg_depend.refobjsubid = pg_attribute.attnum 
                                JOIN pg_namespace dependent_ns ON dependent_ns.oid = dependent_view.relnamespace
                                JOIN pg_namespace source_ns ON source_ns.oid = source_table.relnamespace
                                WHERE 
                                source_ns.nspname = @SCHEMANAME
                                AND source_table.relname = @TABLENAME
                                AND pg_attribute.attnum > 0 
                                group by dependent_ns.nspname 
                                , dependent_view.relname  
                                , source_ns.nspname 
                                , source_table.relname
                                ORDER BY 1,2;", new { SCHEMANAME = schemaName, TABLENAME = tableName });
        }



        public override string GetSpatialQuery(CHXTable cHXTable, QueryGeometry geometry)
        {
            if (cHXTable == null) return null;
            if (geometry == null) return null;

            if (string.IsNullOrEmpty(geometry.Geometry.ToWKT())) return null;

            string result = "";

            if (geometry.Relation == CHXGeometryRelation.intersect)
            {
                result = $"st_intersects({cHXTable.TableName}.{cHXTable.GeometryColumn.Name}, st_geomfromtext('{geometry.Geometry.ToWKT()}', {cHXTable.GeometryColumn.SRID}))";
            }
            else if (geometry.Relation == CHXGeometryRelation.distance)
            {
                if (geometry.Geometry.type != "Point") throw new Exception("Yakınlık analizi yapmak için point geometry olması gerekir.");

                result = $"st_intersects({cHXTable.TableName}.{cHXTable.GeometryColumn.Name}, st_buffer( st_geomfromtext('{geometry.Geometry.ToWKT()}', {cHXTable.GeometryColumn.SRID}), {geometry.Distance}))";
            }

            return result;
        }
    }
}
