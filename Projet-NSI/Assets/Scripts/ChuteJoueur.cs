using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuteJoueur : MonoBehaviour
{
    private Vector3 respawn = new Vector3(0, 3, 0);
    private Vector3 offset = new Vector3(0, 2, 0);
    private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -20)
        {
            // cc.transform.position = respawn;
            // transform.position = respawn;
            cc.Move(-transform.position + respawn);
            Debug.Log(cc.transform.position);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            respawn = other.transform.position + offset;
        }
    }
}
