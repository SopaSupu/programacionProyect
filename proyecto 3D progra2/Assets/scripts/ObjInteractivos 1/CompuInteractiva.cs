using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompuInteractiva : ObjetoInteractivoGenerico
{
    private bool encendido = false;
    public Canvas unityVentanas;

    public override void ActivarAccion()
    {

        if (encendido == false)
        {
            unityVentanas.gameObject.SetActive(true);
            encendido = true;
            textoAccion = "hacer un juego en unity";
        }

        else
        {
            unityVentanas.gameObject.SetActive(false);
            encendido = false;

            textoAccion = "apagar computadora";
        }
    }


}
