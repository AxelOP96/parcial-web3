using System.ComponentModel.DataAnnotations;
using PrimerParcial.Entidades;

namespace PrimerParcial.Web.Models
{
    public class BarcoViewModel
    {
        public int IdBarco { get; set; }

        
        [MaxLength(40, ErrorMessage="El máximo de caracteres es de 40")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "La antiguedad es obligatoria")]
        [Range(1,49, ErrorMessage = "La antiguedad debe estar entre 1 y 49")]
        public int Antiguedad { get; set; }

        
        [Required(ErrorMessage = "La tripulación máxima es obligatoria")]
        [Range(10, 999, ErrorMessage = "La antiguedad debe estar entre 10 y 999")]
        public int TripulacionMaxima { get; set; }
        public double Tasa { get; set; }
        public static Barco ToBarco(BarcoViewModel barcoViewModel)
        {
            return new Barco
            {
                IdBarco = barcoViewModel.IdBarco,
                Nombre = barcoViewModel.Nombre,
                Antiguedad = barcoViewModel.Antiguedad,
                TripulacionMaxima = barcoViewModel.TripulacionMaxima
            };
        }
        public static BarcoViewModel FromBarco(Barco barco)
        {
            return new BarcoViewModel
            {
                IdBarco = barco.IdBarco,
                Nombre = barco.Nombre,
                Antiguedad = barco.Antiguedad,
                TripulacionMaxima = barco.TripulacionMaxima,
                Tasa = barco.Tasa
            };
        }
    }
    
}
