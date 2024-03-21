using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocadorNPCs : MonoBehaviour
{
    private GameObject[] puntosSpaw;


    void Awake()
    {
        
            print("Despertando");
        puntosSpaw = GameObject.FindGameObjectsWithTag("SpawnNPC");
    }
    private void OnDrawGizmos()
    {
        if (puntosSpaw != null)
        {
            //no hago nada
            print("Se encontraron" + puntosSpaw.Length + "puntos de Spawn");
        }
        Gizmos.color = Color.yellow;
        foreach (GameObject punto in puntosSpaw)
        {
            Gizmos.DrawIcon(punto.transform.position, "T_8_Silhouette_");
        }
    }
    public void NPCGenerado(GameObject npc, GameObject generador)
    {
        print("Se generó un nuevo NPC" + npc.name);
        GameObject puntoAleatorio = puntosSpaw[Random.Range(0, puntosSpaw.Length)];

        npc.transform.position = puntoAleatorio.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
