using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    public enum TiposDanio
    {
        Fisico,
        Magico,
        Fuego,
        Aire,
        Cortante,
        Contundente,
    }

    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public static int vidas = 3;
    public bool aturdido = false;
    public bool muerto = false;
    public int MonedaScore = 0;
    public Text Moneda;
    Animator miAnimador;
    public GameObject efectoSangrePrefab;
    public GameObject efectoDanioMagico;
    private ReproductorSonidos misSonidos;
    private Personaje miPersonaje;
    


    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
        miPersonaje = GetComponent<Personaje>();
        MonedaScore = 0;


    }
    private void OnTriggerEnter2D( Collider2D collision)
    {
     if(collision.gameObject.tag== "Meta")
        {
            miAnimador.SetTrigger("festejando");
            muerto = true;
        }
        if (collision.gameObject.tag == "Moneda")
        {
            MonedaScore++;
            Moneda.text = "x " + MonedaScore;
        }
    }

    public void hacerDanio(int puntos, GameObject atacante, TiposDanio tipo = TiposDanio.Fisico)
        //si no se manda el tipo, por defecto toma el fisico
    {
        print(name + "recibe daño de" + puntos + "por" + atacante.name + "de tipo" + tipo);
        //resto los puntos al hp actual
        hp = hp - puntos;
        


        //creo una instancia en la parte de sangre
        GameObject sangre = Instantiate(
            efectoSangrePrefab, transform);
        misSonidos.reproducir("Dañar");

        if (tipo == TiposDanio.Fisico)
        {
            miAnimador.SetTrigger("Dañar");

            aturdido = true;
            //programo que se ejecute el método desaturdir dentro de 1 segundo
            Invoke("desaturdir", 1);
        }
        else if (tipo == TiposDanio.Magico)
        {
            //activar una particula correspondiente
            Instantiate(efectoDanioMagico, transform);
        }

        



        if (hp <= 0)
        {
            muerto = true;
            miAnimador.SetTrigger("Morir");
            Personaje.vidas--;
            Invoke("reanudarEscena", 3);
            


        }
        else
        {
            miAnimador.SetTrigger("Dañar");
        }

        if (miPersonaje.tag == "Player" && hp <= 0 && Personaje.vidas > 0)
        {
            Personaje elPerso = miPersonaje.GetComponent<Personaje>();
            
            muerto = true;
            misSonidos.reproducir("Morir");
            miAnimador.SetTrigger("Morir");
        }


    }

    private void desaturdir()

    {
        aturdido = false;

    }

    private void reanudarEscena()
    {
        muerto = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        hp = hpMax;
    }


    public void perderVida(int puntosVida, GameObject atacante)
    {
        if (hp <= 0)
        {
            print(name + "Muere por " + atacante.name);
            Personaje.vidas = Personaje.vidas - Personaje.vidas;
            misSonidos.reproducir("Morir");
            muerto = true;
            Invoke("morirPersonaje", 4);
        }
    }



  

   
}