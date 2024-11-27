namespace DynamicFormBlazor.Intarfaces
{
    public interface IFormField
    {
        string Type { get; set; }
        string Label { get; set; }
        bool Required { get; set; }
        string? Value { get; set; }
        Dictionary<string, object> GetValidationAttributes();
    }
}
