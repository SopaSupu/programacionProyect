using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class CaminadoSimple : MonoBehaviour
{

    private Rigidbody miCuerpo;
    public float velocidad;
    Vector3 movimiento;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
    }
    void Update()
    {
        movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        miCuerpo.MovePosition(transform.position + (movimiento * velocidad * Time.fixedDeltaTime));
    }

}


    

