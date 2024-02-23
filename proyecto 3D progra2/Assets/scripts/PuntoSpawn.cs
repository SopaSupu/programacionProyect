using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoSpawn : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(
            this.transform.position,
            "T_11_home_");
    }
   
}
