using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class MenuScript : MonoBehaviour
{
    public GameObject menuPanel; // switch on and off

    
    public void Host()
    {
        NetworkManager.Singleton.StartHost();
        menuPanel.SetActive(false);
    }

    public void Join()
    {
        NetworkManager.Singleton.StartClient();
        menuPanel.SetActive(false);
    }
    
} // class
