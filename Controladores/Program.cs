using ejercicioBucles5Obligatorio;
using ejercicioBucles5Obligatorio.Servicios;

namespace ejercicioBucles5Obligatorio
{/// <summary>
/// clase principal del proyecto
/// <author>06112023 -ilp </author>
/// </summary>
    class Program
    {/// <summary>
     /// Clase por la cual se inicia el proyecto
     /// <author>06112023 -ilp </author>
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            string respuesta;
            do
            { solicitudesInterfaz si = new solicitudesImplementacion();

               calculosInterfaz ci = new calculosImplementacion();
                int año, mes;
                 bool bisiesto;


               


                mes = si.numeroMes();
                año = si.numeroAño();
                bisiesto = ci.bisiesto(año);

                switch (mes)
                {
                    case 0:
                        Console.WriteLine("NADA");

                        break;

                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("31");
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("30");


                        if (bisiesto == true)

                            Console.WriteLine("29");
                        break;


                    case 2:


                        Console.WriteLine("28");

                        break;


                    default:
                        Console.WriteLine("[info] - la opcion deseada no existe.");
                        break;





                }

                       
                        
                Console.WriteLine("Si quieres que se repita pulsa s");
                        respuesta = Console.ReadLine();
                
                
            } while (respuesta == "si");

        }
    }
}