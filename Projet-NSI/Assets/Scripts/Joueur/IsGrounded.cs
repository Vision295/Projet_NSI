using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    public bool isGrounded;
    public GameObject joueur;

    void Update()
    {
        // les pieds se déplacent là où est le joueur
        transform.position = joueur.transform.position + new Vector3(0, -0.82f, 0);
    }

    // si le joueur touche le sol
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
