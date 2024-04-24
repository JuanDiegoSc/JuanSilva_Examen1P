using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JuanSilva_Examen1P.Models
{
    public class JS_producto
    {
        [Key]
        public int JsProductoID { get; set; }

        [Required]
        [Display(Name = "Numero de Serie")]
        public int JsnumeroSerie { get; set; }
        [Range(1,20)]
        [Display(Name = "Precio")]
        public decimal Jsprecio { get; set; }

        [StringLength(10, ErrorMessage ="Excede el numero max de caracteres")]
        [Display(Name = "Nombre Producto")]
        public string? JsNombreProducto { get; set; }

        [Required]
        [Display(Name = "Disponibilidad")]
        public bool JsDisponible { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public DateTime JsFechaAgregado { get; set; }
    }
}
