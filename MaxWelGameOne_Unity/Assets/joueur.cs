using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joueur : MonoBehaviour
{

    public float speed;

    public Transform spawnPos;
    public GameObject spawnee;

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
        


        Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        ClassJoueur joueur1 = new ClassJoueur();
    }

    class Joueur
    {
        
    }
}
