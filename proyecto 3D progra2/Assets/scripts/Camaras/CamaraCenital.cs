using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraCenital : MonoBehaviour
{
    public GameObject perso;
    private float distancia = 10;
    void Update()
    {
        transform.position = new Vector3(perso.transform.position.x, distancia, perso.transform.position.z);
    }
}
