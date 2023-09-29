using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Triangulo
    {
       
        int Base = 34;
        int altura = 50;

        public float calcArea()
        {
            return Base * altura /2;
        }


        public Triangulo()
        {
            //este es un constructor, establezco el estado inicial del objeto
            Base = 34;
        }

        public Triangulo(int valorBase, int valorAltura)
        {
          
            Base = valorBase;
            altura = valorAltura;
        }
        public void resultados()
        {
            Console.WriteLine(
                "Este triangulo tiene de base"
                + Base + ", " + "y de altura" + " " + altura
                + ", " + "por lo que su área es de" + calcArea());
        }
    }
}
