using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionObjet : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
