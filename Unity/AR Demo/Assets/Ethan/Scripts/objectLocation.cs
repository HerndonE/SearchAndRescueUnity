/*
Ethan Herndon
Capstone CST 499; Search and Rescue AR prototype
Spring 2021
Description: This program finds the HOST player of the scene, then updates position in realtime.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectLocation : MonoBehaviour
{

    public GameObject hostPlayer;
    public string hostPlayerName;
    private bool findHost = false;

    // Start is called before the first frame update
    void Start()
    {
        hostPlayer = GameObject.Find(hostPlayerName);
        if (hostPlayer)
        {
            findHost = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (findHost == true)
        {
            //For Helicopters (HOST) Position
            //TODO: sending location to a UI text.
            //Debug.Log("x: " + hostPlayer.transform.position.x + " y: " + hostPlayer.transform.position.y + " z: " + hostPlayer.transform.position.z);
        }
    }
}