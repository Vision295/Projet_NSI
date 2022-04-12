using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontePF2 : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    private int allezRetour = 0;
    public float spaceInterval = 10.0f;
    private float backLimit;
    private float forwardLimit;

    void Start()
    {
        backLimit = transform.position.y - spaceInterval;
        forwardLimit = transform.position.y + spaceInterval;
    }

    void Update()
    {
        if (transform.position.y > forwardLimit)
        {
            allezRetour = 1;
        } else if (transform.position.y < backLimit)
        {
            allezRetour = 0;
        }

        if (allezRetour == 0)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        } else if (allezRetour == 1)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }
}
