using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public PopManager popmanag;
    void Detruit(GameObject gameObject)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(popmanag.destroy)
        {
            popmanag.destroy = false;
            Invoke("Detruit", 5f);
        }
    }
}
