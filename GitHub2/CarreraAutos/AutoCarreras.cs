using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
   public class AutoCarreras
    {
        public string modelo;
        public float peso;
        public int velocidad;
        public float gasolina;

       public void PonerGas(float cantidad)
       {
           gasolina = gasolina + cantidad;
           Console.WriteLine(
               modelo +"Tiene" + gasolina +
               "litros de gas.");
       }

       public void Arrancar()
       {
           if (gasolina > 0)
           {
               //consume 0.01 litros de gasolinas cada que arranca
               gasolina = gasolina - 0.01f;
               Console.WriteLine("Arrancando" + modelo + ", le quedan" + gasolina + "litros de gasolina");
           }
           else
           {
               Console.WriteLine(
               "No se puede arrancar" + modelo + "sin gasolina.");
           }
       }

       public void Acelerar(int cantidad)
       {
           velocidad = velocidad + cantidad;
           Console.WriteLine(
               modelo + "Esta yendo a" + velocidad +
               "km/h.");

           gasolina = gasolina - velocidad / 100f;
           Console.WriteLine("la gasolina de" + modelo + "disminuye a" + gasolina + "litros de gasolina");

           if (gasolina <= 0)
           {
               Console.WriteLine("el coche se apagò");
           }
           }
       public void Frenar()
       {
           velocidad = 0;
           Console.WriteLine("el auto frenò por completo");       
       }
       }
    }
