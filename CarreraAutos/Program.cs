using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoCarreras ferrari = new AutoCarreras();
            ferrari.modelo = "Ferrari 5150";
            ferrari.peso = 1.3f;
            ferrari.velocidad = 230;

            AutoCarreras mcLaren = new AutoCarreras();
            ferrari.modelo = "mcLaren A455";
            ferrari.peso = 0.98f;
            ferrari.velocidad = 280;

            PistaCarreras hnsRodriguez = new PistaCarreras();
            hnsRodriguez.nombre = "Autòdromo Hermanos Rodriguez";
            hnsRodriguez.longitud = 5.6f;//en km

            //Mando a competir a mis autos
            hnsRodriguez.Competir(ferrari, mcLaren);

            //le pongo 20 de gas al ferrari
            ferrari.PonerGas(20);
            mcLaren.PonerGas(21);
            ferrari.Arrancar();
            mcLaren.Arrancar();
            ferrari.Acelerar(2);
            mcLaren.Acelerar(1);

            //esta instrucciòn espera a que des enter p continuar
            Console.ReadLine();
        }
    }
}
