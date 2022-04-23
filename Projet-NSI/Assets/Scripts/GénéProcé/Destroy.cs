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
        } else {
            Destroy(transform.parent.gameObject, lifeTime);
        }
    }
}
