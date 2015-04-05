using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using CodeTuts.DataLayer.Configuration;
using CodeTuts.Model.Models;

namespace CodeTuts.DataLayer
{
    public class TutsContext : DbContext
    {
        public TutsContext() : base("CodeTutsConnectionString") {}

        public DbSet<NewsPost> NewsPosts {get; set;}
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
 	        modelBuilder.Configurations.Add(new NewsPostConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
