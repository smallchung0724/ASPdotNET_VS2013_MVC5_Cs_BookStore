namespace Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    using System.Data.Entity.ModelConfiguration.Conventions;

    using Models.Table;

    public class BookStoreContext : DbContext
    { 
        public BookStoreContext()
            : base("BookStoreContext")
        {
        }

        public DbSet<OrderM> OrderM { get; set; }
        public DbSet<OrderD> OrderD { get; set; }
        public DbSet<TrollerM> TrollerM { get; set; }
        public DbSet<TrollerD> TrollerD { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Member> Member { get; set;}
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<BulletinM> BulletinM { get; set; }
        public DbSet<BulletinD> BulletinD { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
