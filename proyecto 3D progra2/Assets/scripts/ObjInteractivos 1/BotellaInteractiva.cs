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
        if (abierto == false)
        {
            miAnimador.SetTrigger("CAER");
            abierto = true;
            textoAccion = "Tirar botella vacía";

        }

        else
        {
            miAnimador.SetTrigger("LEVANTAR");
            abierto = false;
            textoAccion = "Levantar botella vacía";
        }
    }
}
