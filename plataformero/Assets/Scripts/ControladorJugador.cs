using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 3;
    public float fuerzaSalto = 20;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public bool enPiso;//grounded
    public int dobleSalto = 2;
    private ReproductorSonidos misSonidos;
    public int danioArma = 3;
    private Personaje miPersonaje;

    void Start()
    {

        //Al tributo MiCuerpi le asigno el componente Rigidbody 2d de este personaje

        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
        miPersonaje = GetComponent<Personaje>();
    }

    
    void Update()
    {
        if (enPiso == true)
        {
            dobleSalto = 2;
        }



        miAnimador.SetBool("EnPiso", enPiso);
        comprobarPiso();

        float velActualVert = miCuerpo.velocity.y;
        //leo si el jugador está presionando un eje
        //horizontal en las flechas
        float movHoriz = Input.GetAxis("Horizontal");
        if (movHoriz > 0 && !miPersonaje.aturdido && !miPersonaje.muerto)//a la derecha Y el personaje no(!) està aturdido...
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //el 3 es hardcode TT(?
            //con velocidadCaminar ya está parametrizao
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);
        }
        else if (movHoriz < 0 && !miPersonaje.aturdido && !miPersonaje.muerto)//a la izquierda
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(
                -velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);
        }
            else //quieto
        {
            miCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("Caminando", false);
        }
        if (Input.GetButtonDown("Jump") && !miPersonaje.aturdido && !miPersonaje.muerto)
        {
            if (enPiso == true)
            {
                print("Se presionó salto");
                miCuerpo.AddForce(
                    new Vector3(0, fuerzaSalto, 0),
                    ForceMode2D.Impulse);

                misSonidos.reproducir("Saltar");

                dobleSalto = dobleSalto -1;
            }
            else if(enPiso == false && dobleSalto > 0)
            {
                print("Se presionó salto");
                miCuerpo.AddForce(
                    new Vector3(0, fuerzaSalto, 0),
                    ForceMode2D.Impulse);
               

                dobleSalto = dobleSalto - 1;
            }
         
            if (miPersonaje.hp <= 0)
            {
                Invoke("morirPersonaje", 0.5f);
                print("aaaaaaaaaa");
            }
        }

        if (Input.GetButtonDown("Fire1") && !miPersonaje.aturdido && !miPersonaje.muerto)
        {//atacar
            miAnimador.SetTrigger("Atacar");
        }

            miAnimador.SetFloat("VEL_VERT", velActualVert);

        


    }



    void comprobarPiso()
    {
        //lanzo un raYO DE DETECCIóN
        //de colisiones hacia abajo desde la posición del objeto (cavernicola)
        enPiso = Physics2D.Raycast(
            transform.position, Vector2.down, 0.1f);//vector hacia abajo y 0.1 distancia
    }
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        print(name + "hizo colision con" + trigger.gameObject.name);
        GameObject otro = trigger.gameObject;
        if (otro.tag == "Enemigo")
        {
            //Accede al componente de tipo Personaje del objeto con el que choquè
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el daño al otro invocando el metodo hacer daño
            elPerso.hacerDanio(danioArma, this.gameObject);
        }
    }

    }
