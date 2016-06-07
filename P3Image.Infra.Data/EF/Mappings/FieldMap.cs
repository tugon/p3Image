using System.Data.Entity.ModelConfiguration;
using P3Image.Domain.Entities;

namespace P3Image.Infra.Data.EF.Mappings
{
    public partial class FieldMap : EntityTypeConfiguration<Field>
    {

        public FieldMap()
        {
            HasKey(x => x.Id);
            Map();			
            ToTable("TB_FIELD");
            HasMany(m => m.FieldOptions).WithRequired(r => r.Field).HasForeignKey(f => f.FieldId);
        }
    }
}