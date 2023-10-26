using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;
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
    }
    public void perderVida(int puntosVida, GameObject atacante)
    {
        print(name + "Muere por " + atacante.name);
        vidas = vidas - puntosVida;
        hp = 0;
        misSonidos.reproducir("Morir");
    }


    }
