using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBucles5Obligatorio.Servicios
{
    internal class calculosImplementacion : calculosInterfaz

    {
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
