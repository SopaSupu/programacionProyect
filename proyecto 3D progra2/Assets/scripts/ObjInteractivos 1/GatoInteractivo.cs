using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoInteractivo : ObjetoInteractivoGenerico
{
    private AudioSource audioSource;
    public bool Activado = false;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public override void ActivarAccion()
    {

        if (Activado == false)
        {
            audioSource.Play();

            Activado = true;
        }
        else
        {

            audioSource.Stop();
            Activado = false;
        }

    }
}
