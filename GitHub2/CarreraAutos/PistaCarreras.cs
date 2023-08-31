using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class PistaCarreras
    {
        public string nombre;
        public float longitud;

        public void Competir (AutoCarreras auto1, AutoCarreras auto2)
        {
            Console.WriteLine
                ("Iniciando carrera entre"
                + auto1.modelo + "y" + auto2.modelo);

            if(auto1.velocidad > auto2.velocidad)
            {
                Console.WriteLine("Ganó" + auto1.modelo);
            }
            else if (auto2.velocidad > auto1.velocidad)
            {
                Console.WriteLine("Ganó" + auto2.modelo);
            }
            else//tienen la misma velocidad
            {
                Console.WriteLine("Hubo empate");
            }
        
        }
    }
}
