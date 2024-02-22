using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public GameObject areaActual;
    public GameObject areaDestino;

    private void OnTriggerEnter(Collider other)
    {//al entrar en contacto con el teletransportador
        if(other.tag == "Player")
        {
            GameObject player = other.gameObject;
            //desactivo los objetos actuales antes de la transicion
            player.SetActive(false);
            areaActual.SetActive(false);

            //cargo la nueva area y la pongo al centro de la escena
            GameObject nuevaArea = Instantiate(areaDestino);
            nuevaArea.transform.position = Vector3.zero;

            //libero recursos
            Destroy(areaActual);
            //Localizo el punto en donde voy a colocar a mi player
            PuntoSpawn punto =
                GameObject.FindFirstObjectByType<PuntoSpawn>();
            //coloco al player y lo reactivo
            player.transform.position = punto.transform.position;
            player.SetActive(true);
        }

    }
    
    
}
