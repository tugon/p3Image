using System.Data.Entity.ModelConfiguration;
using P3Image.Domain.Entities;

namespace P3Image.Infra.Data.EF.Mappings
{
    public partial class FieldMap : EntityTypeConfiguration<Field>
    {
        public void Map()
        {		    

			// Properties
            this.Property(t => t.Id).HasColumnName("ID");
            this.Property(t => t.SubCategoryId).HasColumnName("SUB_CATEGORY_ID");
            this.Property(t => t.Order).HasColumnName("ORDER");
            this.Property(t => t.Description).HasColumnName("DESCRIPTION");
            this.Property(t => t.FieldType).HasColumnName("FIELD_TYPE");


        }

		/*
        public FieldMap()
        {
			this.HasKey(x=>x.Id);
		    this.Map();			
            this.ToTable("TB_FIELD");        
        }
		*/
    }
}

