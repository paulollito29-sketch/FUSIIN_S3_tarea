using System;
using System.Collections.Generic;
using System.Linq;
using FUSIIN_S2_Ejercicio1.entity;

namespace FUSIIN_S2_Ejercicio1.controller
{
    internal class InventarioController
    {
        private readonly List<Mueble> muebles = new List<Mueble>();

        public bool Registrar(Mueble mueble)
        {
            if (mueble == null)
            {
                return false;
            }

            bool existeCodigo = muebles.Any(x =>
                string.Equals(x.Codigo, mueble.Codigo, StringComparison.OrdinalIgnoreCase));

            if (existeCodigo)
            {
                return false;
            }

            muebles.Add(mueble);
            return true;
        }

        public List<Mueble> ObtenerTodos()
        {
            return muebles
                .OrderByDescending(m => m.Precio)
                .ToList();
        }

        public List<Mueble> BuscarPorNombre(string termino)
        {
            if (string.IsNullOrWhiteSpace(termino))
            {
                return ObtenerTodos();
            }

            return muebles
                .Where(m => m.Nombre.IndexOf(termino, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderByDescending(m => m.Precio)
                .ToList();
        }

        public bool EliminarPorCodigo(string codigo)
        {
            Mueble mueble = muebles.FirstOrDefault(x =>
                string.Equals(x.Codigo, codigo, StringComparison.OrdinalIgnoreCase));

            if (mueble == null)
            {
                return false;
            }

            muebles.Remove(mueble);
            return true;
        }

        public void EliminarTodos()
        {
            muebles.Clear();
        }

        public int TotalMueblesRegistrados()
        {
            return muebles.Count;
        }

        public int TotalStock()
        {
            return muebles.Sum(m => m.Stock);
        }
    }
}
