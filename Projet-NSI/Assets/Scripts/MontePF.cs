using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontePF : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public int allezRetour = 0;
    public float moveInterval = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
