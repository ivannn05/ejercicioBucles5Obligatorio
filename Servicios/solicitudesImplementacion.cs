using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBucles5Obligatorio.Servicios
{
    internal class solicitudesImplementacion : solicitudesInterfaz
    {
        public int numeroMes()
        {
            int numeroMes;
            do
            {
                Console.WriteLine("Introduzca un mes como numero");
                numeroMes = Convert.ToInt32(Console.ReadLine());
            } while (numeroMes < 1 | numeroMes > 12);

            return numeroMes;

        }

        public int numeroAño() 
        {
            int numeroAño;
            
                Console.WriteLine("Introduzca un año como numero");
                numeroAño = Convert.ToInt32(Console.ReadLine());
            
            return numeroAño;

        }
    }
}
