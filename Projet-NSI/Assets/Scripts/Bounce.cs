using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public GameObject joueur;
    void OnCollisionEnter (Collision type) 
    {
        joueur.GetComponent<Rigidbody>().AddForce(Vector3.up * 2000f, ForceMode.Impulse);
    }
}
