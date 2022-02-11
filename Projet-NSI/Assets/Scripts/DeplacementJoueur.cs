using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    private float horizontalInput, verticalInput;
    public float[] speed;
    private Rigidbody rb;
    private bool inputJump;
    private Vector3 mouvement;
    private Vector3 rotation;
    private bool isGrounded = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // regarde cette vidéo : https://www.youtube.com/watch?v=UUJMGQTT5ts&ab_channel=iHeartGameDev

        // Input vertical et horizontal correspond aux flèches du clavier
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Le joueur avance en fonction des inputs horizontaux et verticaux
        mouvement = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddRelativeForce((mouvement * speed[0] - rb.velocity) * rb.mass, ForceMode.Force);

        // La touche espace (space) pour sauter 
        inputJump = Input.GetKeyDown(KeyCode.Space);

        if (inputJump && isGrounded)
        {
            rb.AddForce(Vector3.up * speed[1] * rb.mass, ForceMode.Impulse);
        }
        if (!isGrounded)
        {
            rb.AddForce(Vector3.down * speed[1] * 0.5f * rb.mass, ForceMode.Force);
        }
    }
    void OnCollisionStay(Collision other)
    {
        isGrounded = true;
    }

    void OnCollisionEnter(Collision other)
    {  
        isGrounded = true;
    }
    void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }
}
