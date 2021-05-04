using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI; 

public class PlayerMovement : NetworkBehaviour
{ 
    // Start is called before the first frame update
    CharacterController c; 
    void Start()
    {
        c = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsLocalPlayer)
        {
            MovePlayer();
        }
    }
    
    void MovePlayer()
    {
    Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    move = Vector3.ClampMagnitude(move, 1f);
    c.SimpleMove(move * 5f);
    }
}
