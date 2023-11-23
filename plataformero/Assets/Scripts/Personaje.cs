using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
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
    private ReproductorSonidos misSonidos;
    private Personaje miPersonaje;


    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
        miPersonaje = GetComponent<Personaje>();
        MonedaScore = 0;

    }

    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe da�o de" + puntos + "por" + atacante.name);
        //resto los puntos al hp actual
        hp = hp - puntos;
        miAnimador.SetTrigger("Da�ar");


        //creo una instancia en la parte de sangre
        GameObject sangre = Instantiate(
            efectoSangrePrefab, transform);
        misSonidos.reproducir("Da�ar");

        aturdido = true;
        //programo que se ejecute el m�todo desaturdir dentro de 1 segundo
        Invoke("desaturdir", 1);



        if (hp <= 0)
        {
            muerto = true;
            //hp = 0;
            miAnimador.SetTrigger("Morir");
            Personaje.vidas--;
            Invoke("morirPersonaje", 4);

        }
        if (miPersonaje.tag == "Player" && hp <= 0 && Personaje.vidas > 0)
        {
            Personaje elPerso = miPersonaje.GetComponent<Personaje>();
            //elPerso.morirPersonaje(this.gameObject);
        }


    }

    private void desaturdir()

    {
        aturdido = false;

    }




    public void perderVida(int puntosVida, GameObject atacante)
    {
        if (hp <= 0)
        {
            print(name + "Muere por " + atacante.name);
            Personaje.vidas = Personaje.vidas - Personaje.vidas;
            misSonidos.reproducir("Morir");
            muerto = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Invoke("morirPersonaje", 4);
        }
    }



    private void morirPersonaje(GameObject morir)
    {



    }

    public void bajarVida(int puntosVida, GameObject atacante)

    {
        if (hp <= 0)
        {
            print(name + "Muere por " + atacante.name);
            Personaje.vidas = Personaje.vidas - Personaje.vidas;
            misSonidos.reproducir("Morir");
            muerto = true;
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moneda")
        {
            MonedaScore++;
            Moneda.text = "x " + MonedaScore;
        }
    }
}