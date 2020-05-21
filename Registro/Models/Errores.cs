using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registro.Models
{
    public class Errores
    {
        [Key]
        public int ErrorId { get; set; }
        public DateTime Fecha { get; set; }
        
        [Required(ErrorMessage = "Es oligatorio introducir un hallazgo")]
        public string Hallazgo { get; set; }

        [Required(ErrorMessage ="Es oligatorio introducir una ruta")]
        [Url(ErrorMessage = "Ruta invalida")]
        public string Ruta { get; set; }

        [Range(minimum:1, maximum:10, ErrorMessage ="Rango de importancia invalido")]
        public int Importancia { get; set; }

        public Errores(int hallazgoId, DateTime fecha, string hallazgo, string ruta, int importancia)
        {
            ErrorId = hallazgoId;
            Fecha = fecha;
            Hallazgo = hallazgo;
            Ruta = ruta;
            Importancia = importancia;
        }

        public Errores()
        {
        }
    }
}
