using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPorMouse : MonoBehaviour
{
    public float velocidadRot = 3;

 
    void Update()
    {

        float movHoriz = Input.GetAxis("Mouse X");
        transform.Rotate(
            transform.up * movHoriz * velocidadRot,
            Space.Self);

    }
}
