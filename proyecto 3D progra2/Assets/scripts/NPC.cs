using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            //textoAccion = "Hablar";
            textoAccion = "Estamos en la naDAAAa!!";
        }

        else
        {
            
            miAnimador.SetTrigger("IDLE");
            abierto = true;
            //textoAccion = "Levantar botella";
        }
        if (abierto == true)
        {
            miAnimador.SetTrigger("HABLAR");
            abierto = false;
            textoAccion = "NPC: Estamos en la naDAAAa!!";

        }
      //  if (Input.GetButtonDown("Fire1"))
        //{
          //  miAnimador.SetTrigger("HABLAR");
            //abierto = false;
            //textoAccion = "NPC: Y te pareces a mí, qué chistoso.";

        //}
    }
}

