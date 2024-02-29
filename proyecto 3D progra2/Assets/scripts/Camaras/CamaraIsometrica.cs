using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraIsometrica : MonoBehaviour
{
    public float velocidadCam = 1;
    // Update is called once per frame
    void Update()
    {
        float movHoriz = Input.GetAxis("Mouse X");
        float movVertical = Input.GetAxis("Mouse Y");

        transform.Translate(movHoriz * velocidadCam, 0, movVertical * velocidadCam, Space.World);
    }
}
