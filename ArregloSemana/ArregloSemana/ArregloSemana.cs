using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            //esto es un arreglo de 
            //strings con declaraciòn explìcita
            string[] diasSemana =
            {
                "Domingo", "Lunes", "martes",
                "mièrcoles", "jueves", "viernes",
                "sàbado"};

            int cantDias = diasSemana.Length;

            Console.WriteLine(
                "hay" + cantDias + "dìas en el arreglo.");

            //Asignar un valor en el arreglo
            diasSemana[1] = "Monday";

            //accedo a un elemento y lo
            //guardo en variable
            string diaUno = diasSemana[1];
            string diaTres = diasSemana[3];

            Console.WriteLine(diaUno);
            Console.WriteLine(diaTres);
            //accedo a un elemento y
            //lo uso directamente
            Console.WriteLine(diasSemana[0]);
            Console.WriteLine(diasSemana[4]);

            for(int i = 0; i < 7; i++)//hardcoreado
            {

            }
            for (int i = 0; i < diasSemana.Length; i++)//parametrizado
            {
                //uso la var de control i para acceder a cada elemento del arreglo
                Console.WriteLine(i + ".-" + diasSemana[i]);
            }

            Console.ReadLine();
        }
    }
}
