using System.ComponentModel.DataAnnotations;

namespace P3Image.Web.ViewModels
{
    public class FieldOptionViewModel
    {
        [Key]
        public int Id { get; set; }

        public int FieldId { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public virtual FieldViewModel Field { get; set; }
    }
}