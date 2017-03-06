using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api
{
    public abstract class CHXDataApi: ClaimsPrincipal
    {
        public abstract string GetPermissionName();
        ClaimsPrincipal _principal;
        public abstract object Call(CHXRequest data);
        public int ModelName { get; set; }


        public CHXDataApi(ClaimsPrincipal principal)
        : base(principal)
        {
            _principal = principal;
        }

        public bool IsPermission
        {
            get
            {
                return this.HasClaim(GetPermissionName(), "true");
            }
        }

        public ClaimsPrincipal Principal
        {
            get
            {
                return _principal;
            }

            set
            {
                _principal = value;
            }
        }
    }
}
