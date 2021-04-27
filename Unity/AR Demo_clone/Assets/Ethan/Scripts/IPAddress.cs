using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Net;

public class IPAddress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string hostname = Dns.GetHostName();
        IPHostEntry host = Dns.GetHostEntry(hostname);

        Debug.Log($"Host: {hostname}");


        int count = 0;
        foreach (System.Net.IPAddress address in host.AddressList)
        {
            count++;
            //Debug.Log($"    {address}");
            if (count == host.AddressList.Length)
            {
                Debug.Log($"IPv4 Address: {address}");
            }
        }

       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
}
