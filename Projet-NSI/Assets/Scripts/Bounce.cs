using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public DeplacementJoueur joueur;
    public int test;
    void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        if(hit.gameObject.tag == "Bounce")
        {
            joueur.trampo = true;
            Invoke("Trampo", 0.3f);
        }
    }

    void Trampo()
    {
        joueur.trampo = false;
    }
}
