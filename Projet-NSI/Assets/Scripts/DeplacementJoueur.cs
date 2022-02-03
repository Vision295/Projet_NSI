using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float[] speed =  {0.5f, 0.5f, 7f};
    private Rigidbody rb;
    private bool isGrounded;
    private bool inputJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input vertical et horizontal correspond aux flèches du clavier
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Le joueur avance en fonction des inputs horizontaux et verticaux
        if (horizontalInput != 0)
        {
            rb.AddForce(Vector3.right * horizontalInput * speed[0], ForceMode.Impulse);
            horizontalInput = 0;
        }
        if (verticalInput != 0)
        {
            rb.AddForce(Vector3.forward * verticalInput * speed[1], ForceMode.Impulse);
            verticalInput = 0;
        }

        // La touche espace (space) pour sauter 
        if (!inputJump && isGrounded)
        {
            inputJump = Input.GetKeyDown(KeyCode.Space);
        }

        if (inputJump && isGrounded)
        {
            rb.AddForce(Vector3.up * speed[2], ForceMode.Impulse);
            inputJump = false;
            isGrounded = false;
        }
    }
    void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }
    void OnCollisionEnter(Collision other) 
    {
        isGrounded = true;
    }
}
