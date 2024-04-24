using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JuanSilva_Examen1P.Models
{
    public class JS_producto
    {
        [Key]
        public int JsProductoID { get; set; }

        [Required]
        public int JsnumeroSerie { get; set; }
        [Range(1,20)]
        public decimal Jsprecio { get; set; }

        [StringLength(10, ErrorMessage ="Excede el numero max de caracteres")]
        public string? JsNombreProducto { get; set; }

        [Required]
        [Display(Name = "Disponibilidad")]
        public bool JsDisponible { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime JsFechaAgregado { get; set; }
    }
}
