using System;

namespace FUSIIN_S2_Ejercicio1.entity
{
    internal class Mueble
    {
        public Mueble(string codigo, string nombre, int stock, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
    }
}
