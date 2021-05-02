using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FlightPath : MonoBehaviour
{
    [Header("Flight Speed")]
    public double speed = 1;
    [Header("The Number of Passes (Squared Circles around center)")]
    public int numPassTotal = 10;
    private double numPassCurrent = 1;
    [Header("Initial path length (One side of square)")]
    public int passLength = 10;

    private bool gogogo = false;
    //int temp = 4 * numPassTotal;
    private List<Vector3> pointsSpiral = new List<Vector3>(); //= new Vector3[(4 * numPassTotal)];
    private Vector3[] initialPoints = new Vector3[4];
    //initialPoints[0] = Vector3(1,2,3);
    //private List<List<float>> intitialPoints = new List<List<float>>();

    //List<float> spot1 = new List<float>(0.0f, 0.0f);

    //intitialPoints.Add(new List<float>(0.0f, 0.0f));
    //private Vector3[] intitialPoints = new Vector3[4];
    //private Vector3[] initialLoop = new Vector3[4];
    private float x;
    private float height;
    private float z;
    private int size = 1;
    private int start = 0;
    private int end = 1;
    private float travel = 0;
    private float tempSpeed;
    private bool spin = false;
    private double spinBit = 0;

    // Start is called before the first frame update
    void Start()
    {
        height = transform.position.y;
        /*
        initialPoints[0] = new Vector3(passLength*0, height, passLength*0);
        initialPoints[1] = new Vector3(passLength*0, height, passLength);
        initialPoints[2] = new Vector3(passLength, height, passLength);
        initialPoints[3] = new Vector3(passLength, height, passLength*(-1));
        Debug.Log(initialPoints[0]); //[0] + " ' " + intitialPoints[0][1]);
        Debug.Log(initialPoints[1]); //[0] + " ' " + intitialPoints[1][1]);
        Debug.Log(initialPoints[2]); //[0] + " ' " + intitialPoints[2][1]);
        Debug.Log(initialPoints[3]); //[0] + " ' " + intitialPoints[3][1]);
        */




        for (int i = 0; i <= numPassTotal; i++)
        {
            pointsSpiral.Add(new Vector3(passLength * (-1) * i, height, passLength * (-1) * i));
            pointsSpiral.Add(new Vector3(passLength * (-1) * i, height, passLength * (+1) * (i + 1)));
            pointsSpiral.Add(new Vector3(passLength * (+1) * (i + 1), height, passLength * (+1) * (i + 1)));
            pointsSpiral.Add(new Vector3(passLength * (+1) * (i + 1), height, passLength * (-1) * (i + 1)));
        }

        for (int j = 0; j < pointsSpiral.Count; j++)
        {
            if (j % 4 == 0)
            {
                Debug.Log("------");
            }
            Debug.Log(pointsSpiral[j].x + " , " + pointsSpiral[j].z);
        }


    }


    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown("space")) {
            if (gogogo)
            {
                gogogo = false;
            } else if (!gogogo)
            {
                gogogo = true;
                Debug.Log("GO NOW");
            }

        }


        if (gogogo)
        {
            if (!spin) {
                tempSpeed = (float)(speed / (numPassCurrent + 1)) * 0.01f;
                Debug.Log("TempSpeed: (" + speed + " / " + "( " + numPassCurrent + " + 1)) * 0.01f === " + tempSpeed);
                travel += tempSpeed;
                Debug.Log("Travel: " + travel);
                transform.position = Vector3.Lerp(pointsSpiral[start], pointsSpiral[end], travel);
                Debug.Log("Going to: " + pointsSpiral[end] + " ||| Coming from: " + pointsSpiral[start]);
                if (travel >= 1)
                {
                    start++;
                    end++;
                    numPassCurrent++;
                    travel = 0;
                    //transform.Rotate(0, 90, 0);
                    spin = true;
                }
                if (numPassCurrent >= numPassTotal)
                {
                    gogogo = false;
                    spin = false;
                    Debug.Log("GO END");
                }
           
            } else {
                spinBit += 0.25;
                transform.Rotate(0, 0.25f, 0);
                if(spinBit >= 90)
                {
                    spinBit = 0;
                    spin = false;
                }
            }

        }

        /*
        if (forward == true)
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
        }*/

    }


}
