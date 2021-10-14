using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ApiForAndroid.Data.Entities.Identity
{
    public class User : IdentityUser<long>
    {
        public virtual ICollection<UserRole> UserRoles {get;set;}
    }
}
