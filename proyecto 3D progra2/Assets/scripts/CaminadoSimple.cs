using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CaminadoSimple : MonoBehaviour
{
    public float Velocidad = 3;
    private Rigidbody miCuerpo;
    private Animator miAnimador;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");

        miAnimador.SetFloat("movHoriz", movHoriz);
        miAnimador.SetFloat("movVert", movVert);

        miCuerpo.velocity = (transform.forward * movVert + transform.right * movHoriz) * Velocidad;
    }
}


