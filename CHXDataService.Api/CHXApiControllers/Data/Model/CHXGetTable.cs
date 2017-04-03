using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CHXDataModel;

namespace CHXDataService.Api.CHXApiControllers.Data.Model
{
    public class CHXGetTable : CHXDataApi, ICHXDataApiModel
    {
        public CHXGetTable(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            var serverName = data.Find("server");
            var schemaName = data.Find("schema");
            var tableName = data.Find("tablename");

            if (serverName == null) return null;


            var myDatabase = CHXDatabaseFactory.GetDatabase(serverName.Value.ToString());

            if (myDatabase == null) return null;

            var resultData = myDatabase.Database.Tables.Where(d => d.SchemaName == schemaName.Value.ToString() && d.TableName == tableName.Value.ToString()).Select(d =>
            new
            {
                tablename = d.TableName,
                geometrycolumn = d.GeometryColumn,
                ısspatial = d.IsSpatial,
                ısview = d.IsView,
                schemaname = d.SchemaName,
                ownername = d.OwnerName,
                constraints = d.Constraints.Select(c=> new { name = c.ConstraintName, constrainttype = c.ConstraintType}).ToList(),
                depens = d.DependsTableList.Select(dep=> new { tablename = dep.TableName }).ToList(),
                sequences = d.Sequences.Select(s =>
                                                new
                                                {
                                                    columnname = s.ColumnName,
                                                    currentvalue = s.CurrentValue,
                                                    maximumvalue = s.MaximumValue,
                                                    minimumvalue= s.MinimumValue,
                                                    name = s.SequenceName,
                                                    startvalue = s.StartValue,
                                                    schemaname = s.SchemaName
                                                }).ToList(),
                columns = d.Columns.Select(c=> new
                                            {
                                                name = c.ColumnName,
                                                DataType = c.DataType,
                                                DefaultValue = c.DefaultValue,
                                                IsNullable = c.IsNullable,
                                                MaximumLength = c.MaximumLength
                                            }).ToList()
            }).FirstOrDefault();

            return resultData;
        }

        public override string GetPermissionName()
        {
            return "data.gettable";
        }
    }
}
