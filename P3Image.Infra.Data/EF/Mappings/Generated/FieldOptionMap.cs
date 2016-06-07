using System.Data.Entity.ModelConfiguration;
using P3Image.Domain.Entities;

namespace P3Image.Infra.Data.EF.Mappings
{
    public partial class FieldOptionMap : EntityTypeConfiguration<FieldOption>
    {
        public void Map()
        {		    

			// Properties
            this.Property(t => t.Id).HasColumnName("ID");
            this.Property(t => t.FieldId).HasColumnName("FIELD_ID");
            this.Property(t => t.Text).HasColumnName("TEXT");
            this.Property(t => t.Value).HasColumnName("VALUE");


        }

		/*
        public FieldOptionMap()
        {
			this.HasKey(x=>x.Id);
		    this.Map();			
            this.ToTable("TB_FIELD_OPTION");        
        }
		*/
    }
}

