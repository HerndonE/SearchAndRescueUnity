using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voltron : MonoBehaviour
{

    public GameObject parent;
    //public cameraManager cm;
    public GameObject cm;

    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("hostCarrier");
        this.gameObject.transform.SetParent(parent.transform);


        cm = GameObject.Find("PlaceHolder");
        //this.GetComponent<cameraManager>().assignCamera;
        Debug.Log("test 1: " + this.gameObject);
        Debug.Log("test 2: " + cm.transform.position);
    
        //cm.assignCamera(this.gameObject);
        cm.GetComponent<cameraManager>().assignCamera(this.gameObject);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
