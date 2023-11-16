using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{
    public Personaje heroe;
    public Text etiquetaHPHeroe;
    public Image barraHPHeroe;
    public Text etiquetaScore;
    public Image equis;
    public Text etiquetaVidas;
    public GameObject gameOver;


    // Update is called once per frame
    void Update()
    {
        etiquetaHPHeroe.text =
            heroe.hp + "/" + heroe.hpMax;

        float porcentajeHP =
            heroe.hp / (float)heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHP;
        etiquetaScore.text = "Score: " + heroe.score.ToString();
        etiquetaVidas.text = Personaje.vidas.ToString();
        if (Personaje.vidas <= 0)
        {
            gameOver.SetActive(true);
        }
    }
    
}
