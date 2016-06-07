using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using P3Image.Domain.Entities;
using P3Image.Infra.Data.EF.Mappings;
using P3Image.Infra.Data.Repositories;

namespace P3Image.Infra.Data.EF.Context
{
    public class P3ImageContext : DbContext
    {
        public P3ImageContext()
            : base("Name=P3ImageContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldOption> FieldOptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new SubCategoryMap());
            modelBuilder.Configurations.Add(new FieldMap());
            modelBuilder.Configurations.Add(new FieldOptionMap());
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}