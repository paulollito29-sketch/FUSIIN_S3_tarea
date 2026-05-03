using System;
using System.Collections.Generic;

namespace FUSIIN_S2_Ejercicio1.entity
{
    internal class Torneo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Deporte { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Estado { get; set; } = "Activo";
        public List<Equipo> Equipos { get; set; } = new List<Equipo>();
    }
}
