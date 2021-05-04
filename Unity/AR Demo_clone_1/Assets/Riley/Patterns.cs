using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patterns : MonoBehaviour
{
    public int speed = 5;
    [Header("Patterns: 0 = Expanding Square, 1 = Parallel Track, 2 = Sector")]
    public int pattern = 0;
    [Header("Sector size = O.L.J.*2")]
    public int sectorSize = 5;



    // Start is called before the first frame update
    void Start()
    {
        if (pattern == 1) { 
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
