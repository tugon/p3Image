using System.Data.Entity.ModelConfiguration;
using P3Image.Domain.Entities;

namespace P3Image.Infra.Data.EF.Mappings
{
    public partial class SubCategoryMap : EntityTypeConfiguration<SubCategory>
    {
        public SubCategoryMap()
        {
            HasKey(x => x.Id);
            Map();
            ToTable("TB_SUB_CATEGORY");

            HasRequired(r => r.Category).WithMany(m => m.SubCategories).HasForeignKey(f => f.CategoryId);
        }
    }
}