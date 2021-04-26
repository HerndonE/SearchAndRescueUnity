using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Transports.UNET;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject menuPanel; // switch on and off
    public InputField InputField;

    
    public void Host()
    {
        NetworkManager.Singleton.StartHost();
        menuPanel.SetActive(false);
    }

    public void Join()
    {
        // clicked join -> check if empty
        if (InputField.text.Length <= 0)
        {
            // error check 
            NetworkManager.Singleton.GetComponent<UnetTransport>().ConnectAddress = "127.0.0.1";
            
        } else
        {
            NetworkManager.Singleton.GetComponent<UnetTransport>().ConnectAddress = InputField.text;
        }
        NetworkManager.Singleton.StartClient();
        menuPanel.SetActive(false);
    }
    
} // class
