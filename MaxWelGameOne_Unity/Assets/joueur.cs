using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joueur : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (0, 0, 0);
        if(Input.GetKeyDown("space")){
            Debug.Log("Saut");

            rb.AddForce (0,speed,0,ForceMode.Impulse);
        }
    }
}
