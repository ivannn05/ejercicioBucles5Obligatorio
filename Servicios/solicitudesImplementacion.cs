using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBucles5Obligatorio.Servicios
{
    internal class solicitudesImplementacion : solicitudesInterfaz
    {
        /// <summary>
        /// metodo que pide por consola el numero del mes para introducir
        /// <author>06112023 -ilp </author>
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// metodo que pide por consola el numero del mes para introducir
        /// <author>06112023 -ilp </author>
        /// </summary>
        /// <returns></returns>
        public int numeroAño() 
        {
            int numeroAño;
            
                Console.WriteLine("Introduzca un año como numero");
                numeroAño = Convert.ToInt32(Console.ReadLine());
            
            return numeroAño;

        }
    }
}
