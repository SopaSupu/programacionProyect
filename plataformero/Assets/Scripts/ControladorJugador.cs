using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 3;
    public float fuerzaSalto = 20;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;

    void Start()
    {

        //Al tributo MiCuerpi le asigno el componente Rigidbody 2d de este personaje

        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    
    void Update()
    {
        float velActualVert = miCuerpo.velocity.y;
        //leo si el jugador está presionando un eje
        //horizontal en las flechas
        float movHoriz = Input.GetAxis("Horizontal");
        if (movHoriz > 0) //a la derecha
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //el 3 es hardcode TT(?
            //con velocidadCaminar ya está parametrizao
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);
        }
        else if (movHoriz < 0)//a la izquierda
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
        if (Input.GetButtonDown("Jump"))
        {
            print("Se presionó salto");
            miCuerpo.AddForce(
                new Vector3(0, fuerzaSalto, 0),
                ForceMode2D.Impulse);
        }
        miAnimador.SetFloat("VEL_VERT", velActualVert);
    }
}
