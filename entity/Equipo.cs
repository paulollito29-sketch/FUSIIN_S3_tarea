namespace FUSIIN_S2_Ejercicio1.entity
{
    internal class Equipo
    {
        public string DniDelegado { get; set; }
        public string NombreEquipo { get; set; }
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int PartidosPerdidos { get; set; }

        public int Puntos => (PartidosGanados * 3) + PartidosEmpatados;
    }
}
