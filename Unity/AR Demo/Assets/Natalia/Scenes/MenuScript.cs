using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class MenuScript : MonoBehaviour
{
    public GameObject menuPanel; // switch on and off
    
    public void Host()
    {
        NetworkingManager.Singleton.StartHost();
    }

    public void Join()
    {
        NetworkingManager.Singleton.StartClient();
    }
    
} // class
