using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXAuthenticate
{
    public interface IRegistrationService
    {
        void Register(RegisterUserRequest register);
    }
}
