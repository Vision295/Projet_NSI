using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCamera2 : MonoBehaviour
{
    public GameObject player;
    public Vector3 position, offset, rotation;

    private float xmouse, ymouse;

    // Start is called before the first frame update
    void Start()
    {
        rotation = new Vector3(20, 0, 0);
        offset = new Vector3(0, 5, -5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            xmouse -= 2 * Input.GetAxis("Mouse X");
            ymouse += 2 * Input.GetAxis("Mouse Y");
        }
        transform.position = position + offset;
        transform.rotation = Quaternion.Euler(new Vector3(ymouse, xmouse, 0.0f));
    }
}
