/*
Ethan Herndon
Capstone 499 AR Search and Rescue Prototype
Description: This program uses a button to turn on/off a rawImage in game.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tabCameras : MonoBehaviour
{

    public GameObject rawImage;
    public bool check;

    // Start is called before the first frame update
    void Start()
    {
        rawImage = GameObject.Find("RawImage");
        check = false;
        rawImage.SetActive(false);
    }

    public void tabbing()
    {
        rawImage.SetActive(true);
        check = !check;

        if (check == true)
        {
            rawImage.SetActive(false);
        }

    }

}
