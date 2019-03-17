using NHDai19DemoEF.Model;
using System.Data.Entity;

namespace NHDai19DemoEF.Data
{
    public class DemoDBContext : DbContext
    {
        public DemoDBContext() : base("ConnectionString")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
