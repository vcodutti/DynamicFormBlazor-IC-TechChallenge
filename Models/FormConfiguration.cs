namespace DynamicFormBlazor.Models
{
    public class FormConfiguration
    {
        public string Title { get; set; } = "Dynamic Form";
        public List<FormField> Fields { get; set; } = new();
    }
}
