using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {  // every frame while running . mouse input
            Debug.Log("Pressed primary button.");
            RaycastHit hit; // raycast hit object
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // defining ray 
            if (Physics.Raycast(ray, out hit, 100.0f)) // shooting raycast
            {
                
    	        Debug.Log("I am raycasting");
                 if (hit.collider.gameObject.name == "Cube") // cube is hit 
                 // 
                {    
                    GameObject objectToBeChanged = hit.collider.gameObject; 
                    objectToBeChanged.gameObject.GetComponent<Renderer>().material.color = Color.yellow; 
                    Debug.Log("I am bumblebee"); // hit color change happens    
                }
            } 
        }
    }
}
