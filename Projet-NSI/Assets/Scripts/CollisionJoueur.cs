using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJoueur : MonoBehaviour
{
    public bool collision;
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
}
