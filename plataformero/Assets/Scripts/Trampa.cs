using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public int puntosDanio = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + "hizo colisión con " + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            //Accfedo al componente de tipo personaje del objeto con el que choqué
            Personaje elPerso = otro.GetComponent<Personaje>();
            //aplico el daño al otro invocando el método hacer daño
            elPerso.hacerDanio(puntosDanio, this.gameObject);
        }
    }

}
