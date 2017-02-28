using CHXAuthenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXAuthenticate
{
    public interface IAuthenticationService
    {
        bool TryAuthenticate(Credentials request, out UserIdentity identity);
    }
}
