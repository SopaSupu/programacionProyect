using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public int puntosDanio = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + "hizo colisi�n con " + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            //Accfedo al componente de tipo personaje del objeto con el que choqu�
            Personaje elPerso = otro.GetComponent<Personaje>();
            //aplico el da�o al otro invocando el m�todo hacer da�o
            elPerso.hacerDanio(puntosDanio, this.gameObject);
        }
    }

}
