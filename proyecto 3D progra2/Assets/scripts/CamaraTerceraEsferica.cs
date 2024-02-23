using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTerceraEsferica : MonoBehaviour
{
    public float velocidadRotacion = 1;
    public Transform pivote;
    public float limiteRotacionY = 140f;

    private float rotacionVet = 0f;

    void Update()
    {
        float movHor = Input.GetAxis("Mouse X") * velocidadRotacion;
        float movVer = Input.GetAxis("Mouse Y") * velocidadRotacion;

        pivote.Rotate(Vector3.up * movHor, Space.Self);

        rotacionVet += movVer;
        rotacionVet = Mathf.Clamp(rotacionVet, -limiteRotacionY, limiteRotacionY);
        pivote.localEulerAngles = new Vector3(-rotacionVet, pivote.localEulerAngles.y, 0f);
    }
}
