using Domain.Entities;
using System.Data.Entity;

namespace Infrastructure.Data
{
    public class MarryDBContext : DbContext
    {
        public MarryDBContext() : base ("MarryDBContext")
        {


        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Item> Items { get; set; }

    }
    
}
