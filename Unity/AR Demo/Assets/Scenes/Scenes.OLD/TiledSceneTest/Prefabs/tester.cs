/*using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class tester : MonoBehaviour
{

    //public int distanceToCastRay = 10;

    private string name = "Name: ";
    private string position = "Position: ";
    private string tag = "Tag: ";

    public Text nameText;
    public Text positionText;
    public Text tagText;

    public AudioSource audioData;

    private bool stopPlaying = false;

    public Camera cam;
    [Space]
    public Color paintColor;

    public float radius = 1;
    public float strength = 1;
    public float hardness = 1;


    void Start()
    {
        nameText.text = name;
        positionText.text = position;
        tagText.text = tag;
    }

    void Update()
    {
        *//* Vector3 fwd = transform.TransformDirection(Vector3.forward);
         if (Physics.Raycast(transform.position, fwd, distanceToCastRay))
             print("There is something in front of the object!");
        *//*


       
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out HitInfo, 100.0f))
        {
            //Debug.DrawRay(ray.origin, hit.point - ray.origin, Color.red);
            transform.position = hit.point;
            Paintable p = hit.collider.GetComponent<Paintable>();
            if (p != null)
            {
                PaintManager.instance.paint(p, hit.point, radius, hardness, strength, paintColor);
                nameText.text = name + hit.collider.gameObject.name;
                positionText.text = position + hit.collider.transform.position;
                tagText.text = tag + hit.collider.gameObject.tag;
            }

            *//*GameObject objectToBeChanged = hit.collider.gameObject;
            objectToBeChanged.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            Debug.Log("I am bumblebee"); // hit color change happens    */

            /* ONLY TO PLAY AUDIO
            if (hit.collider.gameObject.tag == "BLAH")
            {
                if (!stopPlaying)
                {
                    audioData.Play();
                    stopPlaying = true;
                }

            }
            else
            {
                if (stopPlaying)
                {
                    audioData.Stop();
                    stopPlaying = false;
                }
            }*//*

            //Debug.Log(name + hit.collider.gameObject.name);
            //Debug.Log(position + hit.collider.transform.position);
        }
        else
        {
            nameText.text = name;
            positionText.text = position;
            tagText.text = tag;
        }

    }
}
*/