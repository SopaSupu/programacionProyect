using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    private Animator miAnimador;
    public GameObject tesoro;
    public bool cercaCofre = false;
    public GameObject boton;
    private ReproductorSonidos misSonidos;
    public GameObject efectoBrillo;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && cercaCofre)
        {
            miAnimador.SetTrigger("OBTENER");
            Instantiate(tesoro, transform.position, Quaternion.identity);
            misSonidos.reproducir("Gato");
            GameObject brillo = Instantiate(efectoBrillo, transform);
        }

    }
    private void OnTriggerEnter2D(Collider2D abrir)
    {

        Cofre cofre = GetComponent<Cofre>();
        print(name + "hizo colision con" + abrir.gameObject.name);
        GameObject otro = abrir.gameObject;

        if (otro.tag == "Player")
        {
            cercaCofre = true;
            boton.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D fuera)
    {

        Cofre cofre = GetComponent<Cofre>();
        print(name + "salio de" + fuera.gameObject.name);
        GameObject otro = fuera.gameObject;


        if (otro.tag == "Player")
        {
            cercaCofre = false;
            boton.SetActive(false);
            
        }
    }

}
 


