using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCamera2 : MonoBehaviour
{
    public GameObject player;
    public Vector3 position = new Vector3(0, 2, -5);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = position;
    }
}
