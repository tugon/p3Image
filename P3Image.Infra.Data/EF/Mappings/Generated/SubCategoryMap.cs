using System.Data.Entity.ModelConfiguration;
using P3Image.Domain.Entities;

namespace P3Image.Infra.Data.EF.Mappings
{
    public partial class SubCategoryMap : EntityTypeConfiguration<SubCategory>
    {
        public void Map()
        {		    

			// Properties
            this.Property(t => t.Id).HasColumnName("ID");
            this.Property(t => t.CategoryId).HasColumnName("CATEGORY_ID");
            this.Property(t => t.Description).HasColumnName("DESCRIPTION");
            this.Property(t => t.Slug).HasColumnName("SLUG");


        }

		/*
        public SubCategoryMap()
        {
			this.HasKey(x=>x.Id);
		    this.Map();			
            this.ToTable("TB_SUB_CATEGORY");        
        }
		*/
    }
}

