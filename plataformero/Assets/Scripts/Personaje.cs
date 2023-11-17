using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Personaje : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public static int vidas = 1;
    public bool aturdido = false;
    public bool muerto = false;
    Animator miAnimador;
    public GameObject efectoSangrePrefab;
    private ReproductorSonidos misSonidos;
    private Personaje miPersonaje;
    

    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
        miPersonaje = GetComponent <Personaje>();
    }

    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe daño de" + puntos + "por" + atacante.name);
        //resto los puntos al hp actual
        hp = hp - puntos;
        miAnimador.SetTrigger("Dañar");


        //creo una instancia en la parte de sangre
        GameObject sangre = Instantiate(
            efectoSangrePrefab, transform);
        misSonidos.reproducir("Dañar");

        aturdido = true;
        //programo que se ejecute el método desaturdir dentro de 1 segundo
        Invoke("desaturdir", 1);

        if (hp < 0 && vidas > 0)
        {
            vidas--;
            muerto = true;
        }

        if (vidas <= 0 && hp <=0)
        {
            muerto = true;
            hp = 0;
            miAnimador.SetTrigger("Morir");

        }
        if (miPersonaje.tag == "Player" && hp <= 0 && vidas > 0)
        {
            Personaje elPerso = miPersonaje.GetComponent<Personaje>();
            elPerso.morirPersonaje(this.gameObject);
        }


    }

    private void desaturdir()
        
    {
        aturdido = false;
        
    }

    

    
    public void perderVida(int puntosVida, GameObject atacante)
    {
        if (hp < 0)
        {
            print(name + "Muere por " + atacante.name);
            vidas = vidas - puntosVida;
            hp = 0;
            misSonidos.reproducir("Morir");
            muerto = true;

        }
    }
    private void morirPersonaje(GameObject morido)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }


}
