/*
Ethan Herndon
Capstone 499 AR Search and Rescue Prototype
Description: This program rotates a given object on first frame.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(-90, 0, 0);
    }

}
