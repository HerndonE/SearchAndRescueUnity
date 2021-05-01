/*
Ethan Herndon
Capstone CST 499; Search and Rescue AR prototype
Spring 2021
Description: This program gets the IPv4 address of your device and displays it as a GUI.
Reference: https://www.c-sharpcorner.com/UploadFile/167ad2/get-ip-address-using-C-Sharp-code/
*/
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Net;
using UnityEngine.UI;

public class IPAddress: MonoBehaviour {

  public Text ipAddressText;

  // Start is called before the first frame update
  void Start() {

    string hostname = Dns.GetHostName();
    IPHostEntry host = Dns.GetHostEntry(hostname);

    //Debug.Log($"Host: {hostname}");

    int count = 0;
    foreach(System.Net.IPAddress address in host.AddressList) {
      count++;
      //Debug.Log($"    {address}");
      if (count == host.AddressList.Length) {
        //Debug.Log($"IPv4 Address: {address}");
        ipAddressText.text = "" + address;
      }
    }

  }

  // Update is called once per frame
  void Update() {

  }

}