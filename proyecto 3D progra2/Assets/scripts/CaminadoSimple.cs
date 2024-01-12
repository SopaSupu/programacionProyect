using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoSimple : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //leo el valor de input del eje vertical,
        //si el valor es mayor a cero, aplicar una velocidad al rb de (0,0, velocidad) y activo el paràmetro caminando del animator
        // si el valor no es mayor a cero, entonces anulo la velocidad y desactivo caminando
    }
}
