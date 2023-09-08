using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNombres
{
    public class GeneradorDeTiposDeGatos
    {
        public string [] Nombre = {"Gato", "Frijol", "Hellokitty", "Atole",
            "Señor", "HotCake", "Flan", "Bola", "Jungkook", "Bombón", "Irwin", "Pinkie Pie" };
        public string [] Apellido = {"Quemado", "Cepeda Lozano", "Pelusa", "De la Noche",
        "Oaxaco", "Papitas", "Gordo", "Cajeta"};

        public void generar(int MesNacimiento, int UltNumCelular)
        {
            if (MesNacimiento > 12)
            {
                Console.WriteLine("Los meses van del 1 al 12");
                return;
            }

            Console.WriteLine(Nombre[MesNacimiento - 1] + "" + Apellido[UltNumCelular - 1] + "");
        }
    }
}
