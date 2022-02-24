using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontePF : MonoBehaviour
{
    private float moveSpeed = 1.0f;
    private int allezRetour = 0;    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 13)
        {
            allezRetour = 1;
        } else if (transform.position.y < -7)
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
