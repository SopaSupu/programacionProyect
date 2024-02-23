using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool bloquearMouse = true;

    void Start()
    {
        if (bloquearMouse)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        
    }

  
}
