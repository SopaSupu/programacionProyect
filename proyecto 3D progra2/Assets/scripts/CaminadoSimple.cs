using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CaminadoSimple : MonoBehaviour
{
    private Rigidbody miCuerpo;
    private Animator miAnimador;
    public int veloPerso = 5;
    public int rotSuav = 3;
    public float gravedad;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        miCuerpo.AddForce(gravedad * Physics.gravity);
        float movHoriz = Input.GetAxisRaw("Horizontal");
        float movVert = Input.GetAxisRaw("Vertical");

        Vector3 direccion = new Vector3(movHoriz, 0, movVert);



        if (direccion.magnitude > 0)
        {
            Vector3 nuevDir = Vector3.Lerp(transform.forward, direccion, Time.deltaTime * rotSuav);
            transform.forward = nuevDir;
            miAnimador.SetBool("CAMINANDO", true);
        }
        else
        {
            miAnimador.SetBool("CAMINANDO", false);
        }

        miCuerpo.velocity = ((transform.forward * veloPerso) * direccion.magnitude);
    }
}


