using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_14
{
    class Program
    {
        static void Main()
        {
            EncuestasC encuesta = new EncuestasC();
           
            do
            {
                Console.Clear();
                Console.Write("===============================\n" +
                "Encuesta Covid-19\n" +
                "===============================\n" +
                "1: Realizar Encuesta\n2: Mostrar datos de la encuesta\n3: Mostrar resultados\n4: Mostrar personas por edad\n5: Salir\n" +
                "===============================\n" +
                "Ingrese una opción: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        EncuestasC.quiz();
                        break;
                    case 2:
                        EncuestasC.Data();
                        break;
                    case 3:
                        EncuestasC.Resultados();
                        break;
                    case 4:
                        EncuestasC.EdadPersona();
                        break;
                    case 5:
                        break;
                }
            } while (option != 5);
        }
    }
}
