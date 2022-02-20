using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    public bool isGrounded;
    public GameObject joueur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = joueur.transform.position + new Vector3(0, -0.82f, 0);
    }
    void OnCollisionStay(Collision other)
    {
        isGrounded = true;
    }

    void OnCollisionEnter(Collision other)
    {  
        isGrounded = true;
    }
    void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }
}
