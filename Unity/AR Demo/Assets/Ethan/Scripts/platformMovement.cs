using System.Collections;
using System.Collections.Generic;
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

    // Update is called once per frame
    void Update()
    {

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

        
    }

}
