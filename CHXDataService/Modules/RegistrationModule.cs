using CHXAuthenticate;
using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Modules
{
    public class RegistrationModule : NancyModule
    {
        public RegistrationModule(IRegistrationService registrationService)
        {
            Post["/register"] = x =>
            {
                var request = this.Bind<RegisterUserRequest>();

                registrationService.Register(request);

                return Negotiate.WithStatusCode(HttpStatusCode.OK);
            };
        }
    }
}
