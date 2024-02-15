using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjetoInteractivo : MonoBehaviour
{

    public string textoAccion;
    private bool playerEnContacto = false;

    public abstract void ActivarAccion();

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ControladorUI.Instancia
                .MostrarInteraccionConObj(this);
            playerEnContacto = true;

        }

       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ControladorUI.Instancia
                .MostrarInteraccionConObj(null);
            playerEnContacto = false;

        }
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X) && playerEnContacto)
            {
            ActivarAccion();

        }
    }
}
