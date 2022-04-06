using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public DeplacementJoueur joueur;
    void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        if(hit.gameObject.tag == "Bounce")
        {
            joueur.trampo = true; // utiliser Invoke
        }
    }
}
