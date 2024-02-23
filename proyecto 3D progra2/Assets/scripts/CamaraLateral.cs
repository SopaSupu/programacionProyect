using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLateral : MonoBehaviour
{
    public Transform Prota;
    void Update()
    {
        transform.position = new Vector3(
           Prota.position.x,
           Prota.position.y,
           0f
           );
    }
}
