using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerObjeto : MonoBehaviour
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
        if (Input.GetButtonDown("Fire2"))
        {
            miAnimador.SetTrigger("RECOGER");
        }
    }
}
