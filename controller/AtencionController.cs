using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUSIIN_S2_Ejercicio1.entity
namespace FUSIIN_S2_Ejercicio1.controller
{
    internal class AtencionController
    {
        public AtencionController() { }


        private int x = 0;

        //arreglo
        private AtencionEntity[] arrAtencion = new AtencionEntity[100];

        //Controlador de atenciones registradas y siguiente posicion disponible
        private int atencionesRegistradas = 0;

        //contadores y acumuladores para os reportes
        private int contServicioLavado = 0;
        private int contServicioEncerado = 0;
        private int contServicioSilicona = 0;

        //montos de servicios
        private float sumaMontosDeLavado = 0;
        private float sumaMontosDeEncerado = 0;
        private float sumaMontosDeSilicona = 0;

        //listar todas las atenciones
        public AtencionEntity[] FindAll()
        {
            return arrAtencion;
        }

        //devolver  la cantidad de servicios brindados de un tipo

        public int ServiciosPorTipo(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return contServicioLavado;
                case 2:
                    return contServicioEncerado;
                default:
                    return contServicioSilicona;
            }
        }

        //devoler el monto promedio por tipo de servicio

        public float montPromedioXServicio(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return sumaMontosDeLavado/contServicioLavado; break;
                case 2:
                    return sumaMontosDeEncerado/contServicioEncerado; break;
                default:
                    return sumaMontosDeEncerado/contServicioSilicona; break;
            }

        }



        
    }
}
