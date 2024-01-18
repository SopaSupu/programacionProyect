using UnityEngine;

public class CaminadoSimple : MonoBehaviour
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
        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");

        miAnimador.SetFloat("DESPL_LATERAL", movHoriz);
        miAnimador.SetFloat("DESPL_FRONTAL", movVert);

        miCuerpo.velocity = (transform.forward + movVert * transform.right * movHoriz) * Velocidad;
    }
}





