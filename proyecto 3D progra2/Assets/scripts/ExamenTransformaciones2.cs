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
             * 2- Escribe un m�todo llamado Mas Lejano 
             * que reciba 3 par�metros de tipo tranforms. 
             * El primero se llamar� pivote y
             * los otros dos se llamar�n A y B. Calcula la magnitud
             * de la distancia que hay entre A y el pivote, 
             * y B y el pivote. 
             * Imprime un mensaje que indique cu�l de los dos
             * es el que est� m�s lejos (magnitud m�s grande)
             * y al final devuelva ese transform.
             */

            /*
             * 3- Escribe un m�todo llamado mirar que 
             * reciba un arreglo o lista de transforms como
             * par�metro.
             * Usando un for, recorre el arreglo y haz que cada 
             * transform vea (se alinee) hacia el objeto siguiente 
             * en la lista usando el m�todo look at.
             */

            /*
             * 4- Escribe un m�todo llamado acercar que reciba
             * dos par�metos de tipo tranform A y B y otro par�metro
             * num�rico de velocidad. Usando la funci�n 
             * lerp, traslada una vez el transform A para que se
             * acerque a la posici�n de B
             * usando como la velocidad como par�metro de tiempo.
             */

            /*
             * 5- Escribe un m�todo llamado explotar que reciba 
             * un arreglo o lista de transforms como par�metro
             * y un par�metro de tipo Vector3 llamado centro.
             * Usando un ciclo for, calcula el vector normal 
             * entre el centro y la posici�n de cada transform
             * y traslada 10 unidades cada transform en la direcci�n
             * del vector normal.
             */


            /*
            * 1- Escribe un m�todo llamado alinear arriba 
            * que reciba dos par�metros de tipo transform
            * A y B. Dentro del m�todo, debes identificar 
            * cu�l de los dos transforms est� m�s arriba
            * y al que est� abajo le asignar�s la posici�n
            * (x original, Y del que est� m�s arriba, Z original)
            */





        }

            }
        } 
