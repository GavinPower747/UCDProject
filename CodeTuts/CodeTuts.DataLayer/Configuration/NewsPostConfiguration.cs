using CodeTuts.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTuts.DataLayer.Configuration
{
    public class NewsPostConfiguration : EntityTypeConfiguration<NewsPost>
    {
        public NewsPostConfiguration()
        {
            Property(np => np.NewsId).IsRequired();
            Property(np => np.UserId).IsRequired();
            Property(np => np.NewsAuthor).HasMaxLength(50).IsRequired();
            Property(np => np.NewsContent).IsRequired();
            Property(np => np.LogDate).IsRequired();
            Ignore(np => np.ObjectState);
        }
    }
}
