using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCamera1 : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    private float xmouse, ymouse;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 2, -5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;

        if (Input.GetMouseButton(1))
        {
            xmouse -= 2 * Input.GetAxis("Mouse X");
            ymouse += 2 * Input.GetAxis("Mouse Y");
        }

        transform.rotation = Quaternion.Euler(new Vector3(ymouse, xmouse, 0.0f));
    }
}
