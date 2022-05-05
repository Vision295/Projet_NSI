using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionObjet : MonoBehaviour
{
    // script pour tous les objets récupérables
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
