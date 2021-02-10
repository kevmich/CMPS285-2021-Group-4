using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace CMPS_285_Project.Features.Users
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public virtual ICollection<UserRole> Roles { get; set; } = new List<UserRole>();
    }

    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
        }
    }
}
