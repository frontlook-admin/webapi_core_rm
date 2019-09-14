using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace webapi_core_rm.Identity
{
    public class user_identity: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? email_address { get; set; }
        public string PictureUrl { get; set; }
    }
}
