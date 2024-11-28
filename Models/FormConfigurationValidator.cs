using DynamicFormBlazor.Models;

namespace DynamicFormBlazor.Services
{
    public class FormConfigurationValidator
    {
        public void Validate(FormConfiguration formConfiguration)
        {
            if (formConfiguration == null)
            {
                throw new Exception("The JSON input cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(formConfiguration.Title))
            {
                throw new Exception("The property Title of the JSON cannot be null or empty.");
            }

            if (formConfiguration.Fields == null)
            {
                throw new Exception("The property Fields of the JSON cannot be null.");
            }

            if (formConfiguration.Fields.Count == 0)
            {
                throw new Exception("The property Fields of the JSON should have at least one field.");
            }

            foreach (var field in formConfiguration.Fields)
            {
                ValidateField(field);
            }
        }

        private void ValidateField(FormField formField)
        {
            if (string.IsNullOrEmpty(formField.Label))
            {
                throw new Exception($"No Label specification for {formField.Type}. Please provide one to continue.");
            }

            if (formField.Type.Equals("number", StringComparison.OrdinalIgnoreCase))
            {
                if (formField.Min < 0)
                {
                    throw new Exception("The value for property Min cannot be less than 0.");
                }

                if (formField.Max < 0)
                {
                    throw new Exception("The value for property Max cannot be less than 0.");
                }

                if (formField.Min > formField.Max)
                {
                    throw new Exception("The value for Min cannot be greater than the value for Max.");
                }
            }

            if (formField.Type.Equals("dropdown", StringComparison.OrdinalIgnoreCase))
            {
                if (formField.Values == null || !formField.Values.Any())
                {
                    throw new Exception("The dropdown field should have at least one value.");
                }
            }
        }
    }
}
