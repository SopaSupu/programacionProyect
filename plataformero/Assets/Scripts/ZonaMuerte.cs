using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{

    public int puntosVida = 1;
    public GameObject efectoAguaPrefab;
    private ReproductorSonidos misSonidos;


    private void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
    }
   
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        print(name + "hizo colisión con" + trigger.gameObject.name);
        GameObject otro = trigger.gameObject;
        
        if (otro.tag == "Player")
        {
            //Accede al componente de tipo Personaje del objeto
            Personaje elPerso = otro.GetComponent<Personaje>();
            //invoco el metodo hacer daño
            elPerso.perderVida(puntosVida, this.gameObject);
            GameObject Agua = Instantiate(
           efectoAguaPrefab, this.transform);
           
            misSonidos.reproducir("Splash");
        }
    }
    
}
