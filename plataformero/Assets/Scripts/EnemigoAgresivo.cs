using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAgresivo : MonoBehaviour
{
    public int Danio = 10;
    public float VelocidadCaminar = 3f;
    public float distanciaAgro = 5;
    public float agroMenor = 3;
    public GameObject efectoAtacar;
    private GameObject heroe;
    private Animator miAnimador;
    private Rigidbody2D miCuerpo;

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
        if (distancia < distanciaAgro & distancia > agroMenor)
        {//el heroe està dentro de la zona de agro
            if (posHeroe.x > posYo.x)
            {//el heroe està a la derecha del villano
                transform.rotation = Quaternion.Euler(0, 0, 0);
                miCuerpo.velocity = new Vector3(VelocidadCaminar, velActualVert, 0);
                miAnimador.SetBool("Atacar", false);
                miAnimador.SetBool("Correr", true);
            }
            else
            {//está a la izquierda
                transform.rotation = Quaternion.Euler(0, 180, 0);
                miCuerpo.velocity = new Vector3(
                -VelocidadCaminar, velActualVert, 0);
                miAnimador.SetBool("Correr", true);
                miAnimador.SetBool("Atacar", false);
            }
        }
        else if(distancia < distanciaAgro && distancia 
            < agroMenor)
        {
            if(posHeroe.x > posYo.x)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                miCuerpo.velocity = new Vector3(0, 0, 0);
                miAnimador.SetBool("Atacar", true);
                miAnimador.SetBool("Correr", false);
            }

        }
        else
        {//fuera de rango de agro

        }
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + "hizo colisión con " + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            //Accfedo al componente de tipo personaje del objeto con el que choqué
            Personaje elPerso = otro.GetComponent<Personaje>();
            //aplico el daño al otro invocando el método hacer daño
            elPerso.hacerDanio(Danio, this.gameObject);
            GameObject Atacar = Instantiate(efectoAtacar, elPerso.transform);
        }
    }
}
