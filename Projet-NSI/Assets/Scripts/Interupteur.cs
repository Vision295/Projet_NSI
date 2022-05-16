using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interupteur : MonoBehaviour
{
    public GameObject pf;
    private bool isActive;
    void OnTriggerEnter(Collider other) // entrer en collision avec un objet 
    {
        if(other.tag == "Player") // le tag doit être Player
        {
            pf.GetComponent<MontePF>().enabled = isActive;   
        }
    }
    void OnTriggerExit(Collider other) // fin de la collision avec l'objet 
    {
        if(other.tag == "Player") // tout ce qui posséde le tag Player serat désactiver 
        {
            isActive = !isActive;
        }
    }
}
