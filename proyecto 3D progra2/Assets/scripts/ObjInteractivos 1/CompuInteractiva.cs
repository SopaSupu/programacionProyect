using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompuInteractiva : ObjetoInteractivoGenerico
{
    private bool prendido = false;
    public GameObject Pum;
    void Start()
    {
       

    }
    public override void ActivarAccion()
    {
        if (prendido == true)
        {
            
            
            prendido = false;
            textoAccion = "Encender Compu";
            GameObject explosion = Instantiate(Pum, transform);
            Pum.transform.position = new Vector3(0, 0, 0);
        }

        else
        {
            
            prendido = true;
            textoAccion = "Usar extintor";
        }
    }


}