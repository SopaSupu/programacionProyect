using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteractiva : ObjetoInteractivoGenerico
{

    public override void ActivarAccion()
    {
        //poner c�mo abrir la puerta
        //rotar puerta 90 grados
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
