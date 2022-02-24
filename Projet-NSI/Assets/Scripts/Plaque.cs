using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaque : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pierre")
        {
            // action à réaliser
            Debug.Log("test");
        }
    }
}
