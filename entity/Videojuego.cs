using System.Collections.Generic;

namespace FUSIIN_S2_Ejercicio1.entity
{
    internal class Videojuego
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; } = new List<Jugador>();
    }
}
