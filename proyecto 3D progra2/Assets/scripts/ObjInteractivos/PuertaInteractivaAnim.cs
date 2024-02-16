using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteractivaAnim : ObjetoInteractivo
{
    private Animator miAnimador;
    private bool estaAbierta = false;
    
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    public override void ActivarAccion()
    {
        if (estaAbierta)
        {
            miAnimador.SetTrigger("CERRAR");
            textoAccion = "Abrir puerta";
        }

        else
        {
            miAnimador.SetTrigger("ABRIR");
            textoAccion = "Cerrar puerta";
        }
        estaAbierta = !estaAbierta;
    }

    
}
