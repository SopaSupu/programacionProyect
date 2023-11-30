using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    
    private ReproductorSonidos misSonidos;
    private Animator miAnimador;
    public GameObject explosión;

    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        miAnimador = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otro = col.gameObject;
        if (otro.tag == "Player")
        {
            misSonidos.reproducir("CELEBRATION");
        
            Personaje elPerso = otro.GetComponent<Personaje>();
            Animator animadorHeroe = otro.GetComponent<Animator>();
            GameObject reaparece = Instantiate(explosión);
            animadorHeroe.SetTrigger("festejando");
            Invoke("siguienteEscena", 6f);
            miAnimador.SetBool("Celebrar", false);
        }
    }

    private void siguienteEscena()
    {
        SceneManager.LoadScene("Expansion");
    }
}
