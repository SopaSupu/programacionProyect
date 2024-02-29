using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTerceraEsferica : MonoBehaviour
{
    public float velRotacion = 1;
    public Transform pivote;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotMouseX = Input.GetAxis("Mouse X");
        pivote.Rotate(Vector3.up * rotMouseX);

        float rotMouseY = Input.GetAxis("Mouse Y");


    }
}
