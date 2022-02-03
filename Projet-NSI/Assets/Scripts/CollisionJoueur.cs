using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJoueur : MonoBehaviour
{
    private GameObject cam;
    private GestionCamera2 scriptCam;
    private Vector3 offset = new Vector3(0, 2, -5);
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
            scriptCam.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
