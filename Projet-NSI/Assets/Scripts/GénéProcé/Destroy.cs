using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public PopManager popmanag;
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5);
    }
}
