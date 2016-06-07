using System.Collections.Generic;

namespace P3Image.Web.ViewModels
{
    public class SubCategoryViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public virtual IList<FieldViewModel> Fields { get; set; }
        public virtual CategoryViewModel Category { get; set; }
    }
}