using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    public float horizontalInput, verticalInput, rotateSpeed = 3f;
    public float[] speed;
    private Rigidbody rb;
    private bool inputJump;
    public Vector3 mouvement, rotationN;
    // variable contenant le script isgrounded
    public IsGrounded pied;
    // variable contenant le script collisionjoueur
    public CollisionJoueur colJ;
    public Manager manag;
    private Quaternion rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // regarde cette vidéo : https://www.youtube.com/watch?v=UUJMGQTT5ts&ab_channel=iHeartGameDev

        // Input vertical et horizontal correspond aux flèches du clavier
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            horizontalInput = 1;
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            horizontalInput = -1;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            horizontalInput = 0;
        } else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            horizontalInput = 0;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            verticalInput = 1;
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            verticalInput = -1;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            verticalInput = 0;
        } else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            verticalInput = 0;
        }

        if(horizontalInput != 0 && !manag.isPaused)
        {
            transform.Rotate(Vector3.up * horizontalInput * rotateSpeed);
        }

        // Le joueur avance en fonction des inputs horizontaux et verticaux
        mouvement = new Vector3(0, 0, verticalInput);
        
        // si le joueur touche le sol ou qu'il n'est pas en collision
        rb.AddRelativeForce((mouvement * speed[0]) * rb.mass, ForceMode.Force);

        inputJump = Input.GetKeyDown(KeyCode.Space);

        // fait sauter le joueur s'il ne touche pas le sol
        if (inputJump && pied.isGrounded)
        {
            rb.AddForce(Vector3.up * speed[1] * rb.mass, ForceMode.Impulse);
        }
        // fait descendre le joueur plus rapidement
        if (!pied.isGrounded)
        {
            rb.AddForce(Vector3.down * speed[1] * 1.5f * rb.mass, ForceMode.Force);
        }
    }
}
