using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidora : MonoBehaviour
{
    // lo siguiente es para referenciar
    // a la pelota de la escena
    //transform se refiere al transform de unity
    public Transform Cavernicola;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //colocar la posicion de la pelota a la camara, excepto z
        transform.position = new Vector3(
            Cavernicola.position.x,
            Cavernicola.position.y,
            -1);
    }
}
