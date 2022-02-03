using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJoueur : MonoBehaviour
{
    private GameObject cam;
    private GestionCamera2 scriptCam;
    private Vector3 offset = new Vector3(0, 5, -5);
    private Vector3 rotationV;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Camera");
        scriptCam = cam.GetComponent<GestionCamera2>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cameraCheckpoint1")
        {
            scriptCam.position = other.transform.position + offset;
            rotationV = new Vector3(cam.transform.rotation.x, cam.transform.rotation.y, cam.transform.rotation.z);
            scriptCam.rotation = new Vector3(20, 0, 0);

        } else if (other.tag == "cameraCheckpoint2")
        {
            scriptCam.position = other.transform.position + new Vector3(5, 5, 0);
            rotationV = new Vector3(cam.transform.rotation.x, cam.transform.rotation.y, cam.transform.rotation.z);
            scriptCam.rotation = new Vector3(20, -90, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
