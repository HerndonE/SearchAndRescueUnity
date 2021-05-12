using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tabCameras : MonoBehaviour
{

    public GameObject rawImage;
    public bool check;

    // Start is called before the first frame update
    void Start()
    {
        rawImage = GameObject.Find("RawImage");
        check = false;
        rawImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tabbing()
    {
        rawImage.SetActive(true);
        check = !check;

        if (check == true)
        {
            rawImage.SetActive(false);
        }

    }

}
