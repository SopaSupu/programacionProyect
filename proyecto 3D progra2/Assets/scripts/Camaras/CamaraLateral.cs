using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLateral : MonoBehaviour
{
    public GameObject Prota;
    private float distancia = 10;
    void Update()
    {
        transform.position = new Vector3(distancia, Prota.transform.position.y + 3, Prota.transform.position.z);
    }
}
