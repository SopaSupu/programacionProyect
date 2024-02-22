using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{
    //esta instancia es mi singleton de controlador de ui
    public static ControladorUI Instancia;
    
    public Text etiquetaAccion;
    public GameObject grupoPrompt;

    private void Start()
    {
        Instancia = this;
    }
    public void MostrarInteraccionConObj(
        ObjetoInteractivoGenerico elObj)
    {
        if (elObj != null)
        {
            //el objeto no es vacio, aì que muestro
            etiquetaAccion.text = elObj.textoAccion;
            grupoPrompt.SetActive(true);
        }
        else
        {
            grupoPrompt.SetActive(false);
        }
        
    }

    
}
