using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using GG.Data.Models;

namespace GG.Data.Mapping
{
    public partial class ApplicationUserMap : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserMap()
        {
            this.HasKey(a => a.Id);

            this.Property(x => x.UserName).IsRequired().HasMaxLength(50);

            this.Property(x => x.PasswordHash).IsRequired().HasMaxLength(150);

            this.Property(x => x.Email).IsRequired().HasMaxLength(100);

            this.Property(x => x.Avatar).HasMaxLength(250);

            this.Property(x => x.PhoneNumber).HasMaxLength(150);

            this.Property(x => x.PhonePrefix).HasMaxLength(50);

        }
    }
}
