using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXAuthenticate
{
    /// <summary>
    /// An Authentication Service to authenticate incoming requests.
    /// </summary>
    public class RegistrationService : BaseService, IRegistrationService
    {
        private readonly ICryptoService cryptoService;

        public RegistrationService(ICryptoService cryptoService)
        {
            this.cryptoService = cryptoService;
        }

        public void Register(RegisterUserRequest register)
        {
                // Let's do this in a transaction, so we cannot register two users
                // with the same name. Seems to be a useful requirement.
                    string hashBase64;
                    string saltBase64;

                    cryptoService.CreateHash(register.Password, out hashBase64, out saltBase64);

                    CHXUser user = new CHXUser()
                    {
                        Name = register.UserName,
                        PasswordHash = hashBase64,
                        PasswordSalt = saltBase64
                    };


        }
    }
}
