/*
Ethan Herndon
Capstone 499 AR Search and Rescue Prototype
Description: This program is attached to a GameObject and finds another GameObject that it 
needs to be attached.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mergePassengerToCarrier : MonoBehaviour
{
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("Carrier1");
        this.gameObject.transform.SetParent(parent.transform);
    }

}
