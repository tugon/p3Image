using System.Collections.Generic;

namespace P3Image.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public virtual IList<SubCategory> SubCategories { get; set; }
    }
}