using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJoueur : MonoBehaviour
{
    private GameObject cam;
    private GestionCamera2 scriptCam;
    // private GestionCamera1 scriptCam;
    private Vector3 rotationV;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Camera");
        // scriptCam = cam.GetComponent<GestionCamera1>();
        scriptCam = cam.GetComponent<GestionCamera2>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cameraCheckpoint1")
        {
            scriptCam.offset = new Vector3(0, 5, -5);

        } else if (other.tag == "cameraCheckpoint2")
        {
            scriptCam.offset = new Vector3(0, 10, -10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
