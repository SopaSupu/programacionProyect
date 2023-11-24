using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PildoraVeneno : MonoBehaviour
{
    

    public int puntosDanio = 5;//pnts de hp
    public float duracionEfecto = 4;//segundos
    private Animator miAnimador;
    private Personaje victima;


    
    void Start()
    {
        miAnimador = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //animar el item para desaparecer
            miAnimador.SetTrigger("DESAPARECER");
            //desactiva el collider
            GetComponent<Collider2D>().enabled = false;
            //obtengo el personaje del onjeto que chocó
            victima = collision.GetComponent<Personaje>();

            InvokeRepeating("envenenar", 1, 1);
            Destroy(this.gameObject, duracionEfecto);

        }
    }
    private void envenenar()
    {
        victima.hacerDanio(
            puntosDanio, this.gameObject, Personaje.TiposDanio.Magico);
    }
}
