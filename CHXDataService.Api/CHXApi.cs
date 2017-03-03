using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api
{
    public abstract class CHXApi: ClaimsPrincipal
    {
        public abstract string GetPermissionName();
        ClaimsPrincipal _principal;
        public abstract void Call(object data);
        public int ModelName { get; set; }


        public CHXApi(ClaimsPrincipal principal)
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
