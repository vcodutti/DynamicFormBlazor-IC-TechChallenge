using DynamicFormBlazor.Intarfaces;

namespace DynamicFormBlazor.Models
{
    public class FormField : IFormField
    {
        public string Type { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public bool Required { get; set; } = false;
        public string? Value { get; set; }
        public bool ValueBool { get; set; } = false;
        public List<string>? Values { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }

        public Dictionary<string, object> GetValidationAttributes()
        {
            var attributes = new Dictionary<string, object>();

            if (Required) attributes["required"] = "required";
            if (Type == "number")
            {
                if (Min.HasValue) attributes["min"] = Min.Value;
                if (Max.HasValue) attributes["max"] = Max.Value;
            }
            return attributes;
        }
    }
}
