using CodeTuts.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTuts.DataLayer.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration() 
        {
            Property(u => u.UserId).IsRequired();
            Property(u => u.RealName).HasMaxLength(50);
            Property(u => u.DOB).IsRequired();
            Property(u => u.Email).IsRequired().HasMaxLength(50);
            Ignore(u => u.ObjectState);
        }
    }
}
