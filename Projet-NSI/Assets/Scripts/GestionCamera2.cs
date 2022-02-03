using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCamera2 : MonoBehaviour
{
    public GameObject player;
    public Vector3 position = new Vector3(0, 2, -5);
    public Quaternion rotation;
    private Vector3 rotationV;

    // Start is called before the first frame update
    void Start()
    {
        rotationV = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        // ne fait rien mdr
        rotation = Quaternion.FromToRotation(rotationV, new Vector3(120, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = position;
        transform.rotation = rotation;
    }
}
