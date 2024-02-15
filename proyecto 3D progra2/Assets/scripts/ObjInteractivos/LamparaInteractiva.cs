using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamparaInteractiva : ObjetoInteractivo
{
    public Light laLuz;
    public override void ActivarAccion()
    {
        //definir como se prende la lampara
        laLuz.gameObject.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
