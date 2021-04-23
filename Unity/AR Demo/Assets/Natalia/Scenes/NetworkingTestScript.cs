using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class NetworkingTestScript : MonoBehaviour
{
    CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer() 
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        move = Vector3.ClampMagnitude(move, 1f);
        cc.SimpleMove(move*5f);
    }
}
