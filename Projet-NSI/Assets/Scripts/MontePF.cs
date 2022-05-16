using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontePF : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    private int allezRetour = 0;
    public float spaceInterval = 10.0f;
    private float downLimit;
    private float upLimit;

    void Start()
    {
        downLimit = transform.position.y - spaceInterval; 
        upLimit = transform.position.y + spaceInterval;
    }

    void Update()
    {
        if (transform.position.y > upLimit) // position de y suppérieur par rapport à la limite de saut
        {
            allezRetour = 1;
        } else if (transform.position.y < downLimit) // position de y suppérieur par rapport à la limite pour tomber
        {
            allezRetour = 0;
        }

        if (allezRetour == 0) // variable alleezRetour vaut 0 
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        } else if (allezRetour == 1) // variable alleezRetour vaut 1 
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }
}
