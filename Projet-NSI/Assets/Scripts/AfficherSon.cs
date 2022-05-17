using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfficherSon : MonoBehaviour
{
    public MainManager MM;

    // Update is called once per frame
    void Update()
    {
        if (MM.son && transform.name == "son")
        {
            foreach (Transform child in transform)
            {
                child.GetComponent<Renderer>().enabled = true;
            }
        } else if(MM.son && transform.name == "sonCoupe")
        {
            foreach (Transform child in transform)
            {
                child.GetComponent<Renderer>().enabled = false;
            }
        } else if(!MM.son && transform.name == "son")
        {
            foreach (Transform child in transform)
            {
                child.GetComponent<Renderer>().enabled = false;
            }
        } else 
        {
            foreach (Transform child in transform)
            {
                child.GetComponent<Renderer>().enabled = true;
            }
        }
    }
}
