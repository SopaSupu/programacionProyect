using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotellaInteractiva : ObjetoInteractivoGenerico
{
    private bool abierto = false;
    private Animator miAnimador;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }
    public override void ActivarAccion()
    {
        if (abierto == true)
        {
            miAnimador.SetTrigger("CAER");
            abierto = false;
            textoAccion = "Tirar botella vacía";

        }

        else
        {
            miAnimador.SetTrigger("LEVANTAR");
           abierto = true;
            textoAccion = "Levantar botella";
        }
    }
}
