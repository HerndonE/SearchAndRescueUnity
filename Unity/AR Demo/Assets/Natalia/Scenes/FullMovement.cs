using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class FullMovement : NetworkBehaviour
{
    CharacterController cc;
    public Transform cameraTransform;
    float pitch = 0f;
    // Start is called before the first frame update
    void Start()
    {

        if (!IsLocalPlayer) 
        {
            cameraTransform.GetComponent<AudioListener>().enabled = false;
            cameraTransform.GetComponent<Camera>().enabled = false;
        } else
        {
            cc = GetComponent<CharacterController>();
            Cursor.lockState = CursorLockMode.Locked;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsLocalPlayer) 
        {   // do moving stuff
            MovePlayer();
            Look();
        }
    }

    void MovePlayer() 
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        move = Vector3.ClampMagnitude(move, 1f);
        move = transform.TransformDirection(move);
        cc.SimpleMove(move*5f);
    }

    void Look()
    {
        float mousex = Input.GetAxis("Mouse X")*3f;
        transform.Rotate(0, mousex, 0);
        pitch -= Input.GetAxis("Mouse Y")*3f;
        pitch = Mathf.Clamp(pitch, -45f, 45f);
        cameraTransform.localRotation = Quaternion.Euler(pitch,0,0);
    }
}
