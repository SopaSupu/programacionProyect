using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    private Animator miAnimador;
    public float velocidad;
    private NavMeshAgent miCuerpo;
   
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        miCuerpo = GetComponent<NavMeshAgent>();
     }


    void Update()
    {
        if (miCuerpo.velocity.magnitude > 0.1)
        {
            miAnimador.SetBool("CAMINAR", true);
        }
        else
        {
            miAnimador.SetBool("CAMINAR", false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            miAnimador.SetTrigger("ATACAR");
        }
    }
}




