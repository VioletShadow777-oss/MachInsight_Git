using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject Button_Handler; 
    private bool isActive = true;

    public void HideButton()
    {
        if (isActive)
        {
            Button_Handler.SetActive(false);
            isActive = false;
        }
        else
        {
            Button_Handler.SetActive(true);
            isActive = true;
        }
    }
}
