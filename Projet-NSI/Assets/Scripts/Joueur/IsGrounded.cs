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
    void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Player" && other.tag != "Bouton" && other.tag != "Respawn" && other.tag != "BonusScore" && other.tag != "BonusVitesse" && other.tag != "Pierre")
        {
            isGrounded = true;
        }
    }

    /* void OnCollisionStay(Collision other)
    {  
        if(other.gameObject.tag != "Player")
        {
            isGrounded = true;
        }
    } */
    
    async void OnTriggerExit(Collider other)
    {
        if(other.tag != "Player" && other.tag != "Bouton" && other.tag != "Respawn" && other.tag != "BonusScore" && other.tag != "BonusVitesse" && other.tag != "Pierre")
        {
            isGrounded = false;
        }
    }
}
