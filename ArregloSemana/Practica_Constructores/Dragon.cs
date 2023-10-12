using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Constructores
{
    class Dragon
    {
        private string tipo = "hielo";
        private string color = "gris";
        private int cantAlas = 4;
        private float peso = 2500;

        public float calcVelocidadVuelo()
        {
            return cantAlas / peso;
        }
        

        public Dragon()
        {
            //este es un constructor, establezco el estado inicial del objeto
            tipo = "fuego";
        }

        public Dragon (string valorTipo, string valorColor)
        {
            //este es otro tipo de constructor pero recibe parámetros
            //atributo = parámetro
            tipo = valorTipo;
            color = valorColor;
        }
        public void presentarse()
        {
            Console.WriteLine(
                "Yo soy un dragón que no entiende la programación, soy de"
                + tipo +" " + "color" + " " + color
                + " " + "Y voy a llorar");
        }

        
    }
}
