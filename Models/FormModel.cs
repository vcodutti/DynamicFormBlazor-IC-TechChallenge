using System.ComponentModel.DataAnnotations;

namespace DynamicFormBlazor.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "JSON Input is required")]
        public string JsonInput { get; set; }
    }
}
