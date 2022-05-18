using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfficherSon : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (MainManager.Instance.son && transform.name == "son")
        {
            foreach (Transform child in transform)
            {
                child.GetComponent<Renderer>().enabled = true;
            }
        } else if(MainManager.Instance.son && transform.name == "sonCoupe")
        {
            foreach (Transform child in transform)
            {
                child.GetComponent<Renderer>().enabled = false;
            }
        } else if(!MainManager.Instance.son && transform.name == "son")
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
