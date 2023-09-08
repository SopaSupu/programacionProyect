using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneradorDeTiposDeGatos generador =
                new GeneradorDeTiposDeGatos();

            generador.generar(11,2);
            Console.Read();


        }
    }
}
