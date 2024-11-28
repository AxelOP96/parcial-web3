using PrimerParcial.Entidades;
namespace PrimerParcial.Logica
{
    public class BarcoLogica : IBarcoLogica
    {
        private static List<Barco> _items = new List<Barco>();

        public void RegistrarBarco(Barco barco)
        {
            barco.IdBarco = _items.Count == 0 ? 1 : _items.Max(x => x.IdBarco) + 1;
            _items.Add(barco);
        }
        public List<Barco> Listado()
        {
            return _items
            .OrderBy(x => x.IdBarco)
            .ToList();
        }
    }

    public interface IBarcoLogica
    {
        void RegistrarBarco(Barco barco);
        List<Barco> Listado();
    }
}
