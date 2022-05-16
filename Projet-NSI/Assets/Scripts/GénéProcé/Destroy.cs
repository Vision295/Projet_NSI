using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private int lifeTime = 10;

   void Start()
   {
        for (int i = 40; i < 50; i+=1)
        {
            Invoke("Hide", i/5f);
            Invoke("Display", i/5f + 0.1f);
        }
   }
    void Update()
    {
        if(transform.parent == null)
        {
            Destroy(gameObject, lifeTime);            
        } else {
            Destroy(transform.parent.gameObject, lifeTime);
        }
    }

    public void Display()
    { 
        foreach (Transform child in transform)
        {
            if(child.name != "Cube")
            {
                child.GetComponent<Renderer>().enabled = true;
            }
        }
    }

    public void Hide()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Renderer>().enabled = false;
        }
    }
}
