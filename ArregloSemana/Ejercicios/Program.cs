using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            triangulo1.resultados();
            float area = triangulo1.calcArea();
            Console.WriteLine(":" + area);
        }
    }
}
