using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float[] speed =  {0.05f, 0.05f, 5f};
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.relativeVelocity);
    }

    void PreUpdate()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        // Input vertical et horizontal correspond aux flèches du clavier
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Le joueur avance en fonction des inputs horizontaux et verticaux
        transform.Translate(Vector3.right * horizontalInput * speed[0]);
        transform.Translate(Vector3.forward * verticalInput * speed[1]);

        // La touche espace (space) pour sauter 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * speed[2]);
        }
    }
}
