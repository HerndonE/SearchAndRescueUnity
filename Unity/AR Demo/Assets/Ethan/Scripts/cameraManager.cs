using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Spawning;
using MLAPI.Transports.UNET;
///
public class cameraManager : MonoBehaviour
{
    /*
    Notes
    Some script called Camera Manager (This is a possible solution)
    Detects host and clients when present
    Populate host and client in array
    Array[0] = host gets normal camera
    Array[1] = client gets ar camera
    Array[2] = client gets ar camera
     */

    public networkDelegator nd;
   
    public GameObject[] assignSessionCam = new GameObject[4];

    public GameObject hostCam;
    public GameObject client1Cam;
    public GameObject client2Cam;
    public GameObject startingCam;

    public int count = 0;



    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("From CM i am saying: " + nd.ipaddress);

        count = (int)nd.myFloat.Value;
        Debug.Log("WHAT IS COUNT?: " + count);
        assignSessionCam[0] = hostCam;
        assignSessionCam[1] = client1Cam;
        assignSessionCam[2] = client2Cam;
        assignSessionCam[3] = startingCam;

        Debug.Log("Array Size @ Start: " + assignSessionCam.Length);

    }

  // Update is called once per frame
    void Update()
    {
    }

    public void assignCamera(GameObject x)
    {
        //GameObject tempCam = assignSessionCam[count];
        //tempCam.SetActive(true);

        //Debug.Log("the real slim shady is: " + x.name);


        GameObject tempheli = GameObject.Find("hostCarrier");
        Debug.Log("pilot name: " + tempheli.gameObject.transform.GetChild(2).gameObject);

        if (count == 0)
        {
            
            assignSessionCam[0].SetActive(true);
            assignSessionCam[1].SetActive(false);
            assignSessionCam[2].SetActive(false);
            assignSessionCam[3].SetActive(false);
        }

        else if (count == 1)
        {
            assignSessionCam[0].SetActive(false);
            assignSessionCam[1].SetActive(true);
            assignSessionCam[2].SetActive(false);
            assignSessionCam[3].SetActive(false);
        }

        else
        {
            assignSessionCam[0].SetActive(false);
            assignSessionCam[1].SetActive(false);
            assignSessionCam[2].SetActive(true);
            assignSessionCam[3].SetActive(false);
        }

        /* for (int i = 0; i < 4; i++)
         {
             Debug.Log("i: " + i);
             if(i != count)
             {
                 assignSessionCam[i].SetActive(false);
             }
         }*/
        GameObject tempCam = assignSessionCam[count];
        tempCam.gameObject.transform.SetParent(x.transform);
        //count++;

    }

}
