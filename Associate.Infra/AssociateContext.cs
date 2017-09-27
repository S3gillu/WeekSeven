
using Associate.Core;
using System.Data.Entity;

namespace Associate.Infra
{
   public class AssociateRepository:DbContext
    {
        public AssociateRepository(): base("AssociateTest")
        {

        }
        public DbSet<AssociateApp> AssociateApps { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Week_7");
        }
    }
}
