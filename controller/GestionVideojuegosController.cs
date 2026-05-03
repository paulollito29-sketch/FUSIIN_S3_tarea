using System;
using System.Collections.Generic;
using System.Linq;
using FUSIIN_S2_Ejercicio1.entity;

namespace FUSIIN_S2_Ejercicio1.controller
{
    internal class GestionVideojuegosController
    {
        private readonly List<Videojuego> videojuegos = new List<Videojuego>();
        private readonly List<Jugador> jugadores = new List<Jugador>();

        public bool RegistrarVideojuego(Videojuego videojuego)
        {
            if (videojuego == null) return false;

            bool existe = videojuegos.Any(v => v.Codigo.Equals(videojuego.Codigo, StringComparison.OrdinalIgnoreCase));
            if (existe) return false;

            videojuegos.Add(videojuego);
            return true;
        }

        public bool RegistrarJugadorEnVideojuego(string codigoVideojuego, Jugador jugador)
        {
            if (jugador == null) return false;

            bool dniExistente = jugadores.Any(j => j.Dni.Equals(jugador.Dni, StringComparison.OrdinalIgnoreCase));
            if (dniExistente) return false;

            Videojuego videojuego = videojuegos.FirstOrDefault(v => v.Codigo.Equals(codigoVideojuego, StringComparison.OrdinalIgnoreCase));
            if (videojuego == null) return false;

            jugadores.Add(jugador);
            videojuego.Jugadores.Add(jugador);
            return true;
        }

        public List<Videojuego> ObtenerVideojuegos()
        {
            return videojuegos.OrderBy(v => v.Nombre).ToList();
        }

        public List<Jugador> ObtenerJugadores()
        {
            return jugadores.OrderBy(j => j.Alias).ToList();
        }

        public List<Videojuego> ObtenerVideojuegosPorDni(string dni)
        {
            return videojuegos
                .Where(v => v.Jugadores.Any(j => j.Dni.Equals(dni, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(v => v.Nombre)
                .ToList();
        }

        public List<Videojuego> ObtenerVideojuegosConMasJugadores()
        {
            if (!videojuegos.Any()) return new List<Videojuego>();

            int maxJugadores = videojuegos.Max(v => v.Jugadores.Count);
            return videojuegos
                .Where(v => v.Jugadores.Count == maxJugadores && maxJugadores > 0)
                .OrderBy(v => v.Nombre)
                .ToList();
        }
    }
}
