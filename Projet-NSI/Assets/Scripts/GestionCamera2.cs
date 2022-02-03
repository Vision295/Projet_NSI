using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCamera2 : MonoBehaviour
{
    public GameObject player;
    public Vector3 position = new Vector3(0, 2, -5);
    public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = new Vector3(20, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = position;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
