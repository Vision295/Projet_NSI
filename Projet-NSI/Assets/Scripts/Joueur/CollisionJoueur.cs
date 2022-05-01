using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJoueur : MonoBehaviour
{
    // stocke les collisions du joueur avec les obstacles
    public bool collision;
    public bool finish = false;
     void OnCollisionStay(Collision other)
    {
        collision = true;
    }

    void OnCollisionEnter(Collision other)
    {  
        collision = true;
    }
    void OnCollisionExit(Collision other)
    {
        collision = false;
    }

    void OnTriggerEnter(Collider other)
    {
        // si le joueur entre en collision avec l'objet de fin de niveau
        if (other.tag == "Finish")
        {
            finish = true;
        }
    }
}
