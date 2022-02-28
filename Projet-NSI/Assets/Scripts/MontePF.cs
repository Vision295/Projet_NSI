using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontePF : MonoBehaviour
{
    private float moveSpeed = 1.0f;
    private int allezRetour = 0;
    public float spaceInterval = 10.0f;
    public float downLimit;
    public float upLimit;

    // Update is called once per frame
    void Start()
    {
        downLimit = transform.position.y - spaceInterval;
        upLimit = transform.position.y + spaceInterval;
    }

    void Update()
    {
        if (transform.position.y > upLimit)
        {
            allezRetour = 1;
        } else if (transform.position.y < downLimit)
        {
            allezRetour = 0;
        }

        if (allezRetour == 0)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        } else if (allezRetour == 1)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }        
    }
}
