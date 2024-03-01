using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamenTransformaciones2 : MonoBehaviour
{

    public Transform MasLejano;
    public Transform B;
    public Transform A;
    public Transform pivote;
    public void AlinearArriba(Transform newX, Transform newZ)
    {
        A = newX;
        B = newZ;
    }


    public static void Main()
    {

        Transform pivote = new Transform() { x = 1, y = 2, z = 3 };
        Transform A = new Transform() { x = 4, y = 5, z = 6 };
        Transform B = new Transform() { x = 7, y = 8, z = 9 };

        Transform MasLejano(Transform pivote, Transform A, Transform B);

        {







            /*
             * 2- Escribe un método llamado Mas Lejano 
             * que reciba 3 parámetros de tipo tranforms. 
             * El primero se llamará pivote y
             * los otros dos se llamarán A y B. Calcula la magnitud
             * de la distancia que hay entre A y el pivote, 
             * y B y el pivote. 
             * Imprime un mensaje que indique cuál de los dos
             * es el que está más lejos (magnitud más grande)
             * y al final devuelva ese transform.
             */

            /*
             * 3- Escribe un método llamado mirar que 
             * reciba un arreglo o lista de transforms como
             * parámetro.
             * Usando un for, recorre el arreglo y haz que cada 
             * transform vea (se alinee) hacia el objeto siguiente 
             * en la lista usando el método look at.
             */

            /*
             * 4- Escribe un método llamado acercar que reciba
             * dos parámetos de tipo tranform A y B y otro parámetro
             * numérico de velocidad. Usando la función 
             * lerp, traslada una vez el transform A para que se
             * acerque a la posición de B
             * usando como la velocidad como parámetro de tiempo.
             */

            /*
             * 5- Escribe un método llamado explotar que reciba 
             * un arreglo o lista de transforms como parámetro
             * y un parámetro de tipo Vector3 llamado centro.
             * Usando un ciclo for, calcula el vector normal 
             * entre el centro y la posición de cada transform
             * y traslada 10 unidades cada transform en la dirección
             * del vector normal.
             */


            /*
            * 1- Escribe un método llamado alinear arriba 
            * que reciba dos parámetros de tipo transform
            * A y B. Dentro del método, debes identificar 
            * cuál de los dos transforms está más arriba
            * y al que está abajo le asignarás la posición
            * (x original, Y del que está más arriba, Z original)
            */





        }

            }
        } 
