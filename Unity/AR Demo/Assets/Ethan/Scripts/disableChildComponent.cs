/*
Ethan Herndon
Capstone 499 AR Search and Rescue Prototype
Description: This program on start is attached to an object and disables a specific
child component within that object.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableChildComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
