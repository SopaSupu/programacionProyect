using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AsignadorDestinoNavegacion : MonoBehaviour
{
    public Transform destino;
    private NavMeshAgent navegador;

    // Start is called before the first frame update
    void Start()
    {
        navegador = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
       if(destino != null)
        {
            navegador.destination = destino.position;
        }
    }
}
