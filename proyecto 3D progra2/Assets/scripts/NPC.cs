using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : ObjetoInteractivoGenerico
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
            miAnimador.SetTrigger("HABLAR");
            abierto = false;
            textoAccion = "Hablar";

        }

        else
        {
            miAnimador.SetTrigger("LEVANTAR");
            abierto = true;
            //textoAccion = "Levantar botella";
        }
    }
}

