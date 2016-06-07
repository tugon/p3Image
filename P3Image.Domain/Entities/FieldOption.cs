namespace P3Image.Domain.Entities
{
    public class FieldOption
    {
        public int Id { get; set; }
        public int FieldId { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public virtual Field Field { get; set; }
    }
}