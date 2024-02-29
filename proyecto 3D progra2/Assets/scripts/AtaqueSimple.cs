using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueSimple : MonoBehaviour
{
    private Animator miAnimador;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            miAnimador.SetTrigger("ATACAR");
        }
    }
}
