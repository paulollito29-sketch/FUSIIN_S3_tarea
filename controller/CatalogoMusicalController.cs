using System;
using System.Collections.Generic;
using System.Linq;
using FUSIIN_S2_Ejercicio1.entity;

namespace FUSIIN_S2_Ejercicio1.controller
{
    internal class CatalogoMusicalController
    {
        private readonly List<Album> albumes = new List<Album>();

        public bool RegistrarAlbum(Album album)
        {
            if (album == null)
            {
                return false;
            }

            bool existe = albumes.Any(a => a.Codigo.Equals(album.Codigo, StringComparison.OrdinalIgnoreCase));
            if (existe)
            {
                return false;
            }

            album.Canciones = album.Canciones ?? new List<Cancion>();
            albumes.Add(album);
            return true;
        }

        public List<Album> ObtenerAlbumes()
        {
            return albumes
                .OrderBy(a => a.Nombre)
                .ToList();
        }

        public Album BuscarAlbumPorCodigo(string codigo)
        {
            return albumes.FirstOrDefault(a => a.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));
        }

        public bool RegistrarCancionEnAlbum(string codigoAlbum, Cancion cancion)
        {
            Album album = BuscarAlbumPorCodigo(codigoAlbum);
            if (album == null || cancion == null)
            {
                return false;
            }

            album.Canciones = album.Canciones ?? new List<Cancion>();
            bool existe = album.Canciones.Any(c => c.Codigo.Equals(cancion.Codigo, StringComparison.OrdinalIgnoreCase));
            if (existe)
            {
                return false;
            }

            album.Canciones.Add(cancion);
            return true;
        }

        public List<string> ObtenerNombresCanciones()
        {
            return albumes
                .SelectMany(a => a.Canciones)
                .Select(c => c.Nombre)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(n => n)
                .ToList();
        }

        public List<string> ObtenerNombresCancionesPorAlbum(string codigoAlbum)
        {
            Album album = BuscarAlbumPorCodigo(codigoAlbum);
            if (album == null)
            {
                return new List<string>();
            }

            return album.Canciones
                .Select(c => c.Nombre)
                .OrderBy(n => n)
                .ToList();
        }

        public Album ObtenerAlbumConMasCanciones()
        {
            if (!albumes.Any())
            {
                return null;
            }

            return albumes
                .OrderByDescending(a => a.Canciones.Count)
                .ThenBy(a => a.Nombre)
                .First();
        }

        public List<string> ObtenerAlbumesDondeEstaCancion(string codigoCancion)
        {
            return albumes
                .Where(a => a.Canciones.Any(c => c.Codigo.Equals(codigoCancion, StringComparison.OrdinalIgnoreCase)))
                .Select(a => a.Nombre)
                .OrderBy(n => n)
                .ToList();
        }

        public (Cancion mayor, Cancion menor) ObtenerCancionMayorYMenorDuracion()
        {
            var canciones = albumes
                .SelectMany(a => a.Canciones)
                .ToList();

            if (!canciones.Any())
            {
                return (null, null);
            }

            Cancion mayor = canciones
                .OrderByDescending(c => c.Duracion)
                .First();
            Cancion menor = canciones
                .OrderBy(c => c.Duracion)
                .First();

            return (mayor, menor);
        }
    }
}
