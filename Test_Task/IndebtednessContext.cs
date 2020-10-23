using System.Data.Entity;

namespace Test_Task
{
    class IndebtednessContext : DbContext
    {
        public IndebtednessContext() : base(nameOrConnectionString: "DbConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Indebtedness> Indebtednesses { get; set; }
    }
}
