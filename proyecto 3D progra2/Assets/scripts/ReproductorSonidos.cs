using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]
public class ReproductorSonidos : MonoBehaviour
{
    public EfectoSonoro[] efectos;
    private AudioSource miFuenteSonora;
    void Start()
    {
        miFuenteSonora = GetComponent<AudioSource>();
    }

    public void reproducir(string accion)
    {
        for (int i = 0; i < efectos.Length; i++)
        {
            EfectoSonoro efecto = efectos[i];
            if (efecto.accion == accion)
            {
                //asigno el archivo al audiosource
                miFuenteSonora.clip =
                    efecto.archivoSonido;
                //reproduzco el sonido
                miFuenteSonora.Play();
                break;
            }
        }
    }

    [Serializable]
    public class EfectoSonoro
    {
        public string accion;
        public AudioClip archivoSonido;
    }
    // Update is called once per frame
    void Update()
    {

    }
}