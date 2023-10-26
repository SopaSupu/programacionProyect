using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequenio : MonoBehaviour
{
    public float distanciaAgro = 5;
    private GameObject heroe;
    public float velocidadCaminar = 3;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;


    void Start()
    {
        heroe = GameObject.FindWithTag("Player");
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }


    void Update()
    {
        Vector3 posHeroe = heroe.transform.position;
        Vector3 posYo = this.transform.position;
        float velActualVert = miCuerpo.velocity.y;

        float distancia = (posYo - posHeroe).magnitude;
        if (distancia < distanciaAgro)
        {//el heroe est� dentro de la zona de agro
            if (posHeroe.x > posYo.x)
            {//el heroe est� a la derecha del villano
                transform.rotation = Quaternion.Euler(0, 0, 0);
                miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
                miAnimador.SetBool("Corriendo", true);
            }
            else
            {//est� a la izquierda
                transform.rotation = Quaternion.Euler(0, 180, 0);
                miCuerpo.velocity = new Vector3(
                -velocidadCaminar, velActualVert, 0);
                miAnimador.SetBool("Corriendo", true);
            }
        }
        else
        {//el heroe est� fuera de la zona de agro

        }
    }

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
