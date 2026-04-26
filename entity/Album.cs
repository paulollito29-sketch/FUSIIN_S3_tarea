using System.Collections.Generic;

namespace FUSIIN_S2_Ejercicio1.entity
{
    internal class Album
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Cancion> Canciones { get; set; } = new List<Cancion>();
    }
}
