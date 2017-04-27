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


            claims.Add(new Claim() { Type = "basic", Value = "true", Id = 0 });
            claims.Add(new Claim() { Type = "data", Value = "true", Id = 1 });
            claims.Add(new Claim() { Type = "data.getalltables", Value = "true", Id = 2 });
            claims.Add(new Claim() { Type = "data.getallviews", Value = "true", Id = 3 });
            claims.Add(new Claim() { Type = "data.getallsequences", Value = "true", Id = 4 });
            claims.Add(new Claim() { Type = "data.getallindexes", Value = "true", Id = 5 });
            claims.Add(new Claim() { Type = "data.getallconstraints", Value = "true", Id = 6 });
            claims.Add(new Claim() { Type = "data.gettable", Value = "true", Id = 7 });
            claims.Add(new Claim() { Type = "data.getview", Value = "true", Id = 8 });
            claims.Add(new Claim() { Type = "data.getconstraint", Value = "true", Id = 9 });
            claims.Add(new Claim() { Type = "data.getindex", Value = "true", Id = 10 });
            claims.Add(new Claim() { Type = "data.getsequence", Value = "true", Id = 11 });

            claims.Add(new Claim() { Type = "settings", Value = "true", Id = 11 });
            claims.Add(new Claim() { Type = "settings.adddatabase", Value = "true", Id = 11 });
            claims.Add(new Claim() { Type = "settings.getalldatabase", Value = "true", Id = 12 });
            claims.Add(new Claim() { Type = "settings.deletedatabase", Value = "true", Id = 13 });

            claims.Add(new Claim() { Type = "model", Value = "true", Id = 14 });
            claims.Add(new Claim() { Type = "model.query", Value = "true", Id = 15 });
            claims.Add(new Claim() { Type = "model.add", Value = "true", Id = 16 });
            claims.Add(new Claim() { Type = "model.delete", Value = "true", Id = 17 });
            claims.Add(new Claim() { Type = "model.getallmodel", Value = "true", Id = 18 });


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
