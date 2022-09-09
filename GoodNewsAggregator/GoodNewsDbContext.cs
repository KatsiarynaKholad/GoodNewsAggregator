using GoodNewsAggregator.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNewsAggregator
{
    public class GoodNewsDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Category> Categories { get; set; }

        private const string ConnectionString =
             "Server=DESKTOP-CSLKGI6;Database=GoodNewsAggregator;" +
             "Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
