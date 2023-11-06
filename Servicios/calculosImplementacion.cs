using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBucles5Obligatorio.Servicios
{
    /// <summary>
    /// Asignacion de implementacion con la interfaz
    /// <author>06112023 -ilp </author>
    /// </summary>
    internal class calculosImplementacion : calculosInterfaz

    {/// <summary>
     /// Llamada para hacer la logica del metodo bisiesto
     /// <author>06112023 -ilp </author>
     /// </summary>
     /// <param name="numeroAño"></param>
     /// <returns></returns>
        public bool bisiesto(int numeroAño)
        {

            bool bisiesto;

            if (numeroAño / 4==0)
            {
                bisiesto = false;
            }
            else if
                (numeroAño / 100 == 0)
            {
                bisiesto = false;
            }
            else if (numeroAño / 400 == 0)
                bisiesto = true;
            else
                bisiesto = false;


            return bisiesto;

        }



    }
}
