using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 1;
    public bool aturdido = false;
    public bool muerto = false;
    Animator miAnimador;
    public GameObject efectoSangrePrefab;
    private ReproductorSonidos misSonidos;
    

    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
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

        if (hp < 0)
        {
            hp = hpMax;
            vidas--;
        }

        if (vidas == 0)
        {
            muerto = true;
            hp = 0;
            miAnimador.SetTrigger("Morir");

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


    }
