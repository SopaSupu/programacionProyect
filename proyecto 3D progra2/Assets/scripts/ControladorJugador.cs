using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
  

{
    public float Velocidad = 3;
    private Rigidbody miCuerpo;
    Vector3 moverse;
    private Animator miAnimador;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        moverse = new Vector3(Input.GetAxisRaw("Horiz"), 0, 
            Input.GetAxisRaw("Vert"));

        miCuerpo.MovePosition(transform.position + (moverse * Velocidad * Time.fixedDeltaTime));
    }
}
