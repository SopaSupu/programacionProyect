using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoDireccional : MonoBehaviour
{

    public float Velocidad = 18;
    private Rigidbody miCuerpo;
    private Animator miAnimador;
    public float gravedad;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        miCuerpo.AddForce(gravedad * Physics.gravity);
        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");

        miAnimador.SetFloat("movHoriz", movHoriz);
        miAnimador.SetFloat("movVert", movVert);

        miCuerpo.velocity = (transform.forward * movVert * Velocidad)  + (transform.right * movHoriz * Velocidad);
    }
}