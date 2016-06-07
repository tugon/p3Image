using System.Collections.Generic;
using P3Image.Domain.Enums;

namespace P3Image.Domain.Entities
{
    public class Field
    {
        public int Id { get; set; }
        public int SubCategoryId { get; set; }

        public int Order { get; set; }
        public string Description { get; set; }
        public FieldType FieldType { get; set; }

        public virtual SubCategory SubCategory { get; set; }
        public virtual IList<FieldOption> FieldOptions { get; set; }
    }
}