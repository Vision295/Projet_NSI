using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interupteur : MonoBehaviour
{
    public GameObject pf;
    private bool isActive;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            pf.GetComponent<MontePF>().enabled = isActive;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isActive = !isActive;
        }
    }
}
