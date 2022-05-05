using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int lifeTime = 10;

    // Update is called once per frame
    void Update()
    {
        if(transform.parent == null)
        {
            Destroy(gameObject, lifeTime);
            // ce code ne fonctionne pas 
            /*for (float i = 8; i < 10; i+=1/10)
            {
                Invoke("Hide", i);
                Invoke("Display", i + 1/10);
            }*/
        } else {
            Destroy(transform.parent.gameObject, lifeTime);
        }
    }

    public void Display()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    public void Hide()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }
}
