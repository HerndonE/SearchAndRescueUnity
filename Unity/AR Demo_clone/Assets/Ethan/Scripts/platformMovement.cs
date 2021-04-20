using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    public int speed;
    public bool forward = false;
    public bool back = false;
    public bool right = false;
    public bool left = false;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

   
    public void ForwardPress()
    {
        transform.position += speed * Vector3.forward * Time.deltaTime;
        Debug.Log("X: " + transform.position.x + "," +
            "Y: " + transform.position.y + "," +
            "Z: " + transform.position.z);
    }
    public void BackwardPress()
    {
        transform.position += speed * Vector3.back * Time.deltaTime;
        Debug.Log("X: " + transform.position.x + "," +
            "Y: " + transform.position.y + "," +
            "Z: " + transform.position.z);
    }

    public void LeftPress()
    {
        transform.position += speed * Vector3.left * Time.deltaTime;
        Debug.Log("X: " + transform.position.x + "," +
            "Y: " + transform.position.y + "," +
            "Z: " + transform.position.z);
    }

    public void RightPress()
    {
        transform.position += speed * Vector3.right * Time.deltaTime;
        Debug.Log("X: " + transform.position.x + "," +
            "Y: " + transform.position.y + "," +
            "Z: " + transform.position.z);
    }

    public void AirplaneModePressON()
    {
        forward = true;
    }

    public void AirplaneModePressOFF()
    {
        forward = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if(forward == true)
        {
            int tempSpeed = 2;
            transform.position += tempSpeed * Vector3.forward * Time.deltaTime;
            Debug.Log("X: " + transform.position.x + "," +
           "Y: " + transform.position.y + "," +
           "Z: " + transform.position.z);
        }

        if (forward == false)
        {
            int tempSpeed = 0;
            transform.position += tempSpeed * Vector3.forward * Time.deltaTime; ;
            Debug.Log("X: " + transform.position.x + "," +
           "Y: " + transform.position.y + "," +
           "Z: " + transform.position.z);
        }



    }

   

    /* OLD CODE
           if (back == true)
            {
                transform.position += speed * Vector3.back * Time.deltaTime;
                Debug.Log("X: " + transform.position.x + "," +
                    "Y: " + transform.position.y + "," +
                    "Z: " + transform.position.z);
            }


            if (forward == true)
            {
                transform.position += speed * Vector3.forward * Time.deltaTime;
                Debug.Log("X: " + transform.position.x + "," +
                    "Y: " + transform.position.y + "," +
                    "Z: " + transform.position.z);
            }
            if (right == true)
            {
                transform.position += speed * Vector3.right * Time.deltaTime;
                Debug.Log("X: " + transform.position.x + "," +
                    "Y: " + transform.position.y + "," +
                    "Z: " + transform.position.z);
            }
            if (left == true)
            {
                transform.position += speed * Vector3.left * Time.deltaTime;
                Debug.Log("X: " + transform.position.x + "," +
                    "Y: " + transform.position.y + "," +
                    "Z: " + transform.position.z);
            }
     */

}
