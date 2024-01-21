using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoDireccional : MonoBehaviour
{
    // crear atributos para el rigidbody, 

    public float Velocidad = 5;
    private Rigidbody miCuerpo;
    private Animator miAnimador;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }


    void Update()
    {
        //leer valor d einput, de los ejes horizontal y vertical y guardarlos en vars

        //Crear un nuevo vector llamado direccion y le asigno el valor horizontal a "x" y el valor vertical a "z"


        //Asignar el vector de direccion a la proipiedad forward del transform

        //Asignar al rb la velocidad a partir de multiplicar el vector forward por la magnitud del vector
        //de direccion por el parametro de velocidad

        //si la magnitud del vector de direccion es igual a 0, activo en animator el parametro boleano de caminado, si no, lo desactivo

        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(movHoriz, 0, movVert);

       
       


        if(dir.magnitude > 0)
        {
            miAnimador.SetBool("CAMINANDO", true);
            transform.forward = dir;
        }
        else
        {
            miAnimador.SetBool("CAMINANDO", false);
        }

        miCuerpo.velocity = (transform.forward * Velocidad) * (dir.magnitude);
    }
}
