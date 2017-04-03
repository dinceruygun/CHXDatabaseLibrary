using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;
using CHXDataModel;

namespace CHXDataService.Api.CHXApiControllers.Settings.Model
{
    public class CHXAddDatabase : CHXDataApi, ICHXDataApiModel
    {
        public CHXAddDatabase(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            if (method.ToLower() != "put") return null;


            var _name = data.Find("name");
            var _type = data.Find("type");
            var _parameters = data.Find("parameters");

            if (_name == null) return null;
            if (_type == null) return null;
            if (_parameters == null) return null;


            if (CHXDatabaseFactory.DatabaseCollection[_name.Value.ToString()] != null) return "Aynı isimden veri tabanı bulunuyor";


            CHXDatabaseType databaseType = (CHXDatabaseType)System.Enum.Parse(typeof(CHXDatabaseType), _type.Value.ToString());
           var parameters = new CHXDatabaseParameters();
            parameters.AddRange(_parameters.Select(p => new CHXDatabaseParameter(p.Name, p.Value.ToString())));

            CHXDatabaseFactory.AddDatabase(_name.Value.ToString(), parameters, databaseType);


            return _name.Value.ToString();
        }

        public override string GetPermissionName()
        {
            return "settings.adddatabase";
        }
    }
}
