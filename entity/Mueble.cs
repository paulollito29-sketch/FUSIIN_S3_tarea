using System.Collections.Generic;
using System.Linq;

namespace FUSIIN_S2_Ejercicio1.entity
{
    internal class Cancion
    {
        public Cancion(string codigo, string nombre, double duracion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Duracion = duracion;
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Duracion { get; set; }
    }

    internal class Album
    {
        public Album(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
            Canciones = new List<Cancion>();
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Cancion> Canciones { get; }

        public bool AgregarCancion(Cancion cancion)
        {
            if (cancion == null)
            {
                return false;
            }

            bool existe = Canciones.Any(c => c.Codigo.Equals(cancion.Codigo, System.StringComparison.OrdinalIgnoreCase));
            if (existe)
            {
                return false;
            }

            Canciones.Add(cancion);
            return true;
        }
    }
}
