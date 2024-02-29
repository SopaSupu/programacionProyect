using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteractiva : ObjetoInteractivoGenerico
{
    private bool abierto = false;
    public override void ActivarAccion()
    {
        if (abierto == false)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
            abierto = true;
            textoAccion = "Cerrar Puerta";
        }

        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            abierto = false;
            textoAccion = "Abrir Puerta";
        }
    }
}
