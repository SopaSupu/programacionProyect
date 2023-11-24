using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionVida : MonoBehaviour
{
    private Animator miAnimador;
    public int curarPuntos = 20;
    public Personaje heroe;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

   
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D curar)
    {
        PocionVida pocion = GetComponent<PocionVida>();
        print(name + "hizo colision con" + curar.gameObject.name);
        GameObject otro = curar.gameObject;
        if (otro.tag == "Player" && heroe.hp < 80)
        {
            miAnimador.SetTrigger("OBTENER");
            heroe.hp = heroe.hp + curarPuntos;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 1);
        }
    }
   
    
}
