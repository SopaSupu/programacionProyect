using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{
    public Personaje heroe;
    public Text etiquetaHPHeroe;
    public Image barraHPHeroe;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        etiquetaHPHeroe.text =
            heroe.hp + "/" + heroe.hpMax;

        float porcentajeHP =
            heroe.hp / (float)heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHP;
    }
}
