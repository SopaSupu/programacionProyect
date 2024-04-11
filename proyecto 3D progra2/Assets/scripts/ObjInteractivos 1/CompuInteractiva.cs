using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompuInteractiva : ObjetoInteractivoGenerico
{
   


    private bool prendido = false;
    private Animator miAnimador;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }
    public override void ActivarAccion()
    {
        if (prendido == true)
        {
            miAnimador.SetTrigger("EXPLOTAR");
            prendido = false;
            textoAccion = "Encender compu";

        }

        else
        {
            miAnimador.SetTrigger("EXPLOTAR");
            prendido = true;
            textoAccion = "Usar extintor";
        }
    }

}
