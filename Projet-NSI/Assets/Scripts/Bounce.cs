using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public DeplacementJoueur joueur;
    public int test;
    void OnControllerColliderHit(ControllerColliderHit hit) // donne des informations à propos d'une collision avec un objet 
    {
        if(hit.gameObject.tag == "Bounce") // le tag de l'objet doit être Bounce 
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
