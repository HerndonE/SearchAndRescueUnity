using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Spawning;
using MLAPI.Transports.UNET;

public class RileyNetwork : MonoBehaviour
{

    public GameObject connectionPanel;
    public string ipaddress = "127.0.0.1";

    UNetTransport transport;
    // HAPPENING ON SERVER 
    public void Host() 
    {
        
        Debug.Log("HOST JOINED");
        connectionPanel.SetActive(false);
        NetworkManager.Singleton.ConnectionApprovalCallback += AprrovalCheck;
        NetworkManager.Singleton.StartHost(hostSpawn(), Quaternion.identity);
    }
    
    // HAPPENING ON SERVER
    private void AprrovalCheck(byte[] connectionData, ulong clientID, NetworkManager.ConnectionApprovedDelegate callBack)
    {
        
        // check the incoming data
        bool approve = System.Text.Encoding.ASCII.GetString(connectionData) == "Password1234";
        callBack(true, null, approve, clientSpawn(), Quaternion.identity);
    }    


    public void Join()
    {
        Debug.Log("CLIENT JOINED");
        transport = NetworkManager.Singleton.GetComponent<UNetTransport>();
        transport.ConnectAddress = ipaddress;
        connectionPanel.SetActive(false);
        NetworkManager.Singleton.NetworkConfig.ConnectionData = System.Text.Encoding.ASCII.GetBytes("Password1234");
        NetworkManager.Singleton.StartClient();
    }


    Vector3 hostSpawn()
    {
        float x = 0f;
        float y = 10f;
        float z = 2.5f;
        return new Vector3(x, y, z);
    }

    Vector3 clientSpawn()
    {
        float x = 0f;
        float y = 10f;
        float z = 0f;
        return new Vector3(x, y, z);
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
} // EO CLASS 
