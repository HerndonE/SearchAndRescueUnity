using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mergePassengerToCarrier : MonoBehaviour
{
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("Carrier1");
        this.gameObject.transform.SetParent(parent.transform);
    }

    // Update is called once per frame
    void Update()
    {

    }
}