using System;
using System.Collections.Generic;
using System.Linq;
using FUSIIN_S2_Ejercicio1.entity;

namespace FUSIIN_S2_Ejercicio1.controller
{
    internal class GestionVideojuegosController
    {
        private readonly List<Torneo> torneos = new List<Torneo>();
        private readonly List<Equipo> equipos = new List<Equipo>();

        public bool RegistrarTorneo(Torneo torneo)
        {
            if (torneo == null) return false;

            bool existe = torneos.Any(t => t.Codigo.Equals(torneo.Codigo, StringComparison.OrdinalIgnoreCase));
            if (existe) return false;

            torneos.Add(torneo);
            return true;
        }

        public bool RegistrarEquipoEnTorneo(string codigoTorneo, Equipo equipo)
        {
            if (equipo == null) return false;

            bool dniExistente = equipos.Any(e => e.DniDelegado.Equals(equipo.DniDelegado, StringComparison.OrdinalIgnoreCase));
            if (dniExistente) return false;

            Torneo torneo = torneos.FirstOrDefault(t => t.Codigo.Equals(codigoTorneo, StringComparison.OrdinalIgnoreCase));
            if (torneo == null) return false;

            equipos.Add(equipo);
            torneo.Equipos.Add(equipo);
            return true;
        }

        public List<Torneo> ObtenerTorneos() => torneos.OrderBy(t => t.Nombre).ToList();

        public List<Equipo> ObtenerEquipos() => equipos.OrderBy(e => e.NombreEquipo).ToList();

        public List<Torneo> ObtenerTorneosPorDniDelegado(string dni)
        {
            return torneos
                .Where(t => t.Equipos.Any(e => e.DniDelegado.Equals(dni, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(t => t.Nombre)
                .ToList();
        }

        public List<Equipo> ObtenerTopEquiposPorPuntos(int limite = 5)
        {
            return equipos
                .OrderByDescending(e => e.Puntos)
                .ThenByDescending(e => e.PartidosGanados)
                .ThenBy(e => e.NombreEquipo)
                .Take(limite)
                .ToList();
        }
    }
}
