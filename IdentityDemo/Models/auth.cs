using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace IdentityDemo.Models
{
    public static class auth
    {
       

        public static bool IsSignedInWithFacebook(this IIdentity identity)
        {
            // since the Facebook authentication handler add following claim
            // we could check to see if user has this claim or not
            var claimIdent = identity as ClaimsIdentity;
            return claimIdent != null
                && claimIdent.HasClaim(c => c.Type == "urn:facebook:name");
        }
    }
}