using System.Collections.Generic;

namespace P3Image.Domain.Entities
{
    public class SubCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public virtual IList<Field> Fields { get; set; }
        public virtual Category Category { get; set; }
    }
}