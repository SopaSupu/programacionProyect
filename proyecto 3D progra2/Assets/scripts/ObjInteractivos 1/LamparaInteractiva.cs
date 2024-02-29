using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamparaInteractiva : ObjetoInteractivoGenerico
{
    private bool encendido = false;
    public Light laLuz;

    public override void ActivarAccion()
    {

        if (encendido == false)
        {
            laLuz.gameObject.SetActive(true);
            encendido = true;
            textoAccion = "encender lámpara";
        }

        else
        {
            laLuz.gameObject.SetActive(false);
            encendido = false;

            textoAccion = "apagar lámpara";
        }
    }
}
