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
                "hay" + cantDias + "dìas en el arreglo.")

                Console.ReadLine();
        }
    }
}
