using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{

    CharacterController characterController;
    // Start is called before the first frame update
    public float movementSpeed;


    private Vector3 moveDirection = Vector3.zero;

    float smooth = 5.0f;
    float tiltAngle = 60.0f;
    float y;


    // Update is called once per frame

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    //Update is called once per frame
    void FixedUpdate()
    {

        if (!isLocalPlayer)
        {
            return;
        }

        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        

            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("z"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
        }
        else if (Input.GetKey("z") && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }

        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        if (Input.GetKey("q") && !Input.GetKey("d"))
        {
            y -= Time.deltaTime * 50;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }
        else if (Input.GetKey("d") && !Input.GetKey("q"))
        {
            y += Time.deltaTime * 50;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }

        if (Input.GetKey("space"))
        {
            transform.position += transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed * 2.5f;
        }

        
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
