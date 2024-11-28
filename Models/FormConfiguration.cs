namespace DynamicFormBlazor.Models
{
    public class FormConfiguration
    {
        public string Title { get; set; }
        public List<FormField> Fields { get; set; } = new();
    }
}
