using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Spawning;

public class ConnectionObject : MonoBehaviour
{
    // happens on server
    public void Host()
    {
        NetworkManager.Singleton.ConnectionApprovalCallback += AprrovalCheck;
        NetworkManager.Singleton.StartHost(Vector3.zero, Quaternion.identity);
    }

    // happens on server
    private void AprrovalCheck(byte[] connectionData, ulong clientID, MLAPI.NetworkManager.ConnectionApprovedDelegate callBack)
    {
        // check the incoming data
        bool approve = System.Text.Encoding.ASCII.GetString(connectionData) == "Password1234";
        callBack(true, null, approve, Vector3.zero, Quaternion.identity);
    }    
    public void Join()
    {
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
} // class
