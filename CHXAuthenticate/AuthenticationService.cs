using CHXAuthenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CHXAuthenticate
{
    /// <summary>
    /// Simple Database-based Authentification Service. 
    /// </summary>
    public class AuthenticationService : BaseService, IAuthenticationService
    {
        private readonly ICryptoService cryptoService;

        public AuthenticationService(ICryptoService cryptoService)
        {
            this.cryptoService = cryptoService;
        }

        public bool TryAuthenticate(Credentials credentials, out UserIdentity identity)
        {

            identity = null;

            CHXUser user = new CHXUser() { Name = "netcad", PasswordSalt = "zTCzpgHUJKQQbE8hXg==", PasswordHash = "VErPokc5xJBc58FT4vVXcF+GA+tuO0Pbxfp3nsXcRv1IZGGTe8Ge4iOaMulzOr8hQ6AH2cUwGamXeBUSCQA+jA==" };

            // Check if there is a User:
            if (credentials.UserName != user.Name)
            {
                return false;
            }

            // Make sure the Hashed Passwords match:
            if (user.PasswordHash != cryptoService.ComputeHash(credentials.Password, user.PasswordSalt))
            {
                return false;
            }

            // We got a User, now obtain his claims from DB:
            IList<Claim> claims = new List<Claim>() { };
            
            claims.Add(new Claim() { Type = "data", Value = "true", Id = 1 });
            claims.Add(new Claim() { Type = "data.getalltables", Value = "true", Id = 2 });
            claims.Add(new Claim() { Type = "data.getallviews", Value = "true", Id = 3 });
            claims.Add(new Claim() { Type = "data.getallsequences", Value = "true", Id = 4 });
            claims.Add(new Claim() { Type = "data.getallindexes", Value = "true", Id = 5 });
            claims.Add(new Claim() { Type = "data.getallconstraints", Value = "true", Id = 6 });
            claims.Add(new Claim() { Type = "data.gettable", Value = "true", Id = 7 });
            claims.Add(new Claim() { Type = "data.getview", Value = "true", Id = 8 });
            claims.Add(new Claim() { Type = "data.getconstraint", Value = "true", Id = 9 });

            // And return the UserIdentity:
            identity = Convert(user, claims);

            return true;
        }

        /// <summary>
        /// Converts between Model and DB Entity.
        /// </summary>
        UserIdentity Convert(CHXUser user, IList<Claim> claims)
        {
            if (user == null)
            {
                return null;
            }
            return new UserIdentity()
            {
                Id = user.Id,
                Name = user.Name,
                Claims = Convert(claims)
            };
        }

        /// <summary>
        /// Converts between Model and DB Entity.
        /// </summary>
        IList<ClaimIdentity> Convert(IList<Claim> entities)
        {
            if (entities == null)
            {
                return null;
            }
            return entities.Select(x => Convert(x)).ToList();
        }

        /// <summary>
        /// Converts between Model and DB Entity.
        /// </summary>
        ClaimIdentity Convert(Claim entity)
        {
            return new ClaimIdentity()
            {
                Id = entity.Id,
                Type = entity.Type,
                Value = entity.Value
            };
        }
    }
}
