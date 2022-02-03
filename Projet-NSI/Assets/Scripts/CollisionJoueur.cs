using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJoueur : MonoBehaviour
{
    private GameObject cam;
    private GestionCamera2 scriptCam;
    private Vector3 offset = new Vector3(0, 2, -5);
    private Vector3 rotationV;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Camera");
        scriptCam = cam.GetComponent<GestionCamera2>();
    }

    void OnTriggerEnter(Collider other)
    {
        // l'angle 
        if(other.tag == "cameraCheckpoint")
        {
            scriptCam.position = other.transform.position + offset;
            rotationV = new Vector3(cam.transform.rotation.x, cam.transform.rotation.y, cam.transform.rotation.z);
            scriptCam.rotation = Quaternion.FromToRotation(rotationV, new Vector3(180, 180, 30));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
