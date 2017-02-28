using Nancy;
using Nancy.Security;
using System.Security.Claims;
using System.Security.Principal;

namespace CHXDataService.Modules
{
    public abstract class SecureModule : NancyModule
    {
        public SecureModule()
            : base()
        {
        }

        public SecureModule(string modulePath)
            : base(modulePath)
        {
        }

        protected ClaimsPrincipal Principal
        {
            get
            {
                return this.Context.GetMSOwinUser();
            }
        }

        protected IIdentity CurrentIdentity
        {
            get
            {
                return Principal.Identity;
            }
        }

        protected bool IsAuthenticated
        {
            get
            {
                if (Principal == null)
                {
                    return false;
                }
                if (Principal.Identity == null)
                {
                    return false;
                }


                
                return Principal.Identity.IsAuthenticated;
            }
        }
    }
}
