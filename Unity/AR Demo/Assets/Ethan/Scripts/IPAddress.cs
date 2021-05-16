/*
Ethan Herndon
Capstone 499 AR Search and Rescue Prototype
Description: This program accesses the device name and IPv4 address of the device that this scene is 
running on.
*/
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Net;
using UnityEngine.UI;

public class IPAddress : MonoBehaviour
{

    public Text ipAddressText;

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
                ipAddressText.text = ""+address;
            }
        }

       

    }
  
}
