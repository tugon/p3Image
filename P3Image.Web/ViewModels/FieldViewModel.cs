using System.Collections.Generic;
using P3Image.Web.ViewModels.Enums;

namespace P3Image.Web.ViewModels
{
    public class FieldViewModel
    {
        public int Id { get; set; }
        public int SubCategoryId { get; set; }

        public int Order { get; set; }
        public string Description { get; set; }
        public FieldType FieldType { get; set; }

        public virtual SubCategoryViewModel SubCategory { get; set; }
        public virtual IList<FieldOptionViewModel> FieldOptions { get; set; }


    }
}