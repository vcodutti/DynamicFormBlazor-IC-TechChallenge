using System.ComponentModel.DataAnnotations;

namespace DynamicFormBlazor.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string JsonInput { get; set; }
    }
}
