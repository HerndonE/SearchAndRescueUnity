using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Spawning;
using MLAPI.Transports.UNET;

public class testNetwork : MonoBehaviour
{

    public GameObject connectionPanel;
    public string ipaddress = "127.0.0.1";
    public string display = "Riley Network Placeholder";


    public Camera startingCamera;

    UNetTransport transport;
    // HAPPENING ON SERVER 
    public void Host()
    {

        Debug.Log("HOST JOINED");
        connectionPanel.SetActive(false);
        NetworkManager.Singleton.ConnectionApprovalCallback += AprrovalCheck;
        NetworkManager.Singleton.StartHost(hostSpawn(), Quaternion.identity);


        startingCamera.enabled = false;

        GameObject carrierHost = GameObject.Find("Carrier1");
        carrierHost.SetActive(true);


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

        GameObject passengerClient = GameObject.FindGameObjectWithTag("passenger");
        passengerClient.GetComponent<mergePassengerToCarrier>().enabled = true;


    }


    Vector3 hostSpawn()
    {
        float x = 10f;
        float y = 20f;
        float z = 0f;
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
        return new Vector3(x, y, z);
    }

    public void IPAddressChanged(string newAddress)
    {
        this.ipaddress = newAddress;
    }
} // EO CLASS 
