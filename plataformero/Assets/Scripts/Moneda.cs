using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
   

        private ReproductorSonidos misSonidos;
        private Animator miAnimador;

        void Start()
        {
            misSonidos = GetComponent<ReproductorSonidos>();
            miAnimador = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")

            {
                misSonidos.reproducir("Recolectar");
                GetComponent<SpriteRenderer>().enabled = false;
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                Destroy(this.gameObject, 1f);
            }

        
    }
}
