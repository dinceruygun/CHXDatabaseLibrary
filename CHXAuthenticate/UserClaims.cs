using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXAuthenticate
{
    public class UserClaims : Entity
    {
        public string UserId { get; set; }

        public string ClaimId { get; set; }

        public override string ToString()
        {
            return string.Format("UserClaim ({0}, UserId: {1}, ClaimId: {2})", base.ToString(), UserId, ClaimId);
        }
    }
}
