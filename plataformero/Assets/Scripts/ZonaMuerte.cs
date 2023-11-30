using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{

    public int puntosVida = 1;
    public GameObject efectoAguaPrefab;
    private ReproductorSonidos misSonidos;
    public int Danio = 60;
    private GameObject heroe;


    private void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        heroe = GameObject.FindWithTag("Player");
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
            GameObject Agua = Instantiate(efectoAguaPrefab.gameObject, elPerso.transform);
           

            
            //aplico el daño al otro invocando el método hacer daño
            elPerso.hacerDanio(Danio, this.gameObject);

            misSonidos.reproducir("Splash");
            
        }
    }
    
}
