﻿using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace GG.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        public string Avatar { get; set; }

        public bool Sex { get; set; }

        public string PhonePrefix { get; set; }

        public virtual ICollection<UserActivities> UserActivities { get; set; }

        public virtual ICollection<Blog> Blog { get; set; }

        public virtual ICollection<BlogType> BlogType { get; set; }
    }
}
