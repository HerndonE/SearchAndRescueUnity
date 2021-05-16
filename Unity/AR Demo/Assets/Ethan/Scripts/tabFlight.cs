/*
Ethan Herndon
Capstone 499 AR Search and Rescue Prototype
Description: This program uses a button to turn on/off an objects set path in game.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tabFlight : MonoBehaviour
{
    public GameObject playerAsset;
    public GameObject flightButton;
    public Sprite onButton;
    public Sprite offButton;
    public bool check;

    // Start is called before the first frame update
    void Start()
    {
        flightButton = GameObject.Find("TabFlight");
        playerAsset = GameObject.Find("hostCarrier");
        playerAsset.GetComponent<FlightPath>();
        check = false;
        GetComponent<FlightPath>().enabled = false;
        flightButton.GetComponent<Image>().sprite = offButton;
    }

    public void tabbing()
    {
        //playerAsset.SetActive(true);
        GetComponent<FlightPath>().enabled = true;
        flightButton.GetComponent<Image>().sprite = onButton;
        check = !check;

        if (check == true)
        {
            GetComponent<FlightPath>().enabled = false;
            flightButton.GetComponent<Image>().sprite = offButton;
        }

    }
}
