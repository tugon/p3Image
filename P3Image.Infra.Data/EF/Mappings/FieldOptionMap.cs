using System.Data.Entity.ModelConfiguration;
using P3Image.Domain.Entities;

namespace P3Image.Infra.Data.EF.Mappings
{
    public partial class FieldOptionMap : EntityTypeConfiguration<FieldOption>
    {

        public FieldOptionMap()
        {
            HasKey(x => x.Id);
            Map();
            ToTable("TB_FIELD_OPTION");
        }
    }
}