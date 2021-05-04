using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Reference: https://stackoverflow.com/questions/63426940/what-is-the-best-way-to-dynamically-generate-3d-objects-on-a-grid-in-unity

public class gridMaker : MonoBehaviour
{

    public GameObject gridObject;
    public int[] gridSize;


    void Start()
    {
        for (int i = 0; i < gridSize.Length; i++)
        {
            for (int j = 0; j < gridSize.Length; j++)
            {
                GameObject tempgridObject = Instantiate(gridObject);
                tempgridObject.transform.position = new Vector3(i, 0, j); //Places the cube on the x and z which is updated in the for loops
            }
        }
    }
}
