/*
Ethan Herndon
Capstone 499 AR Search and Rescue Prototype
Description: This program is to test object movement using the WASD keys.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMovement : MonoBehaviour
{
    public float speed = 20f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
