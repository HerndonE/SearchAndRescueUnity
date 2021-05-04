using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Spawning;
using MLAPI.Transports.UNET;

public class ConnectionObject : MonoBehaviour
{

    public GameObject connectionBottomPanel;

    public string ipaddress = "127.0.0.1";

    UNetTransport transport;

    // happens on server
    public void Host()
    {
        connectionBottomPanel.SetActive(false);
        NetworkManager.Singleton.ConnectionApprovalCallback += AprrovalCheck;
        NetworkManager.Singleton.StartHost(GetRandomSpwan(), Quaternion.identity);
    }

    // happens on server
    private void AprrovalCheck(byte[] connectionData, ulong clientID, NetworkManager.ConnectionApprovedDelegate callBack)
    {
        
        // check the incoming data
        bool approve = System.Text.Encoding.ASCII.GetString(connectionData) == "Password1234";
        callBack(true, null, approve, GetRandomSpwan(), Quaternion.identity);
    }    
    public void Join()
    {
        transport = NetworkManager.Singleton.GetComponent<UNetTransport>();
        transport.ConnectAddress = ipaddress;
        connectionBottomPanel.SetActive(false);
        NetworkManager.Singleton.NetworkConfig.ConnectionData = System.Text.Encoding.ASCII.GetBytes("Password1234");
        NetworkManager.Singleton.StartClient();
    }


    Vector3 GetRandomSpwan()
    {
        float x = Random.Range(-10f, +10f);
        float y = Random.Range(-10f, +10f);
        float z = Random.Range(-10f, +10f);
        return new Vector3(x,y,z);
    } 

    public void IPAddressChanged(string newAddress) 
    {
        this.ipaddress = newAddress;
    }
} // class
