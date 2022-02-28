using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCamera1 : MonoBehaviour
{
    public GameObject player;
    public DeplacementJoueur DP;
    public Vector3 offset;
    private float xmouse, ymouse = 25f;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 5, -5);
        DP = player.GetComponent<DeplacementJoueur>();
        transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetMouseButton(1))
        {
            xmouse -= 2 * Input.GetAxis("Mouse X");
            ymouse += 2 * Input.GetAxis("Mouse Y");
        }

        transform.rotation = Quaternion.Euler(new Vector3(ymouse, xmouse, 0.0f)); */
    }
}
