using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{

   
    

    void Start()
    {
      
    }

    void Update()
    {
        /* Vector3 fwd = transform.TransformDirection(Vector3.forward);

         if (Physics.Raycast(transform.position, fwd, distanceToCastRay))
             print("There is something in front of the object!");
        */


        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {


            //Debug.Log(name + hit.collider.gameObject.name);
            //Debug.Log(position + hit.collider.transform.position);

            GameObject objectToBeChanged = hit.collider.gameObject;
            objectToBeChanged.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            Debug.Log("I am bumblebee"); // hit color change happens    
        }
        else
        {
           
        }

    }
}
