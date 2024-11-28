using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Entidades
{
    public class Barco
    {
            public int IdBarco { get; set; }

            [Required(ErrorMessage ="El nombre es obligatorio")]
            public string Nombre { get; set; }
            public int Antiguedad { get; set; }
            public int TripulacionMaxima { get; set; }
            public double Tasa => (Antiguedad * 0.25) + (TripulacionMaxima / 3);
    }
}
