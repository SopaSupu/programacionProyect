using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjetoInteractivoGenerico : MonoBehaviour
{
    public string textoAccion;
    private bool playerEnContacto = false;

    public abstract void ActivarAccion();

    private void OnTriggerEnter(Collider other)
    {
        
    }
    

}
