using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraCenital : MonoBehaviour
{
    public GameObject perso;
    public float distancia = 7;
    void Update()
    {
        transform.position = new Vector3(perso.transform.position.x, distancia, perso.transform.position.z);
    }
}
