using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float[] speed =  {500f, 500f, 7f};
    private CharacterController cc;
    private bool isGrounded;
    private bool inputJump;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // regarde cette vidéo : https://www.youtube.com/watch?v=UUJMGQTT5ts&ab_channel=iHeartGameDev

        // Input vertical et horizontal correspond aux flèches du clavier
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Le joueur avance en fonction des inputs horizontaux et verticaux
        cc.SimpleMove(Vector3.forward * verticalInput * Time.deltaTime * speed[0] 
        + Vector3.right * horizontalInput * Time.deltaTime * speed[1]);
        // cc.SimpleMove(Vector3.right * horizontalInput * Time.deltaTime);
        // transform.Rotate(0, horizontalInput * Time.deltaTime, 0);

        // La touche espace (space) pour sauter 
        if (!inputJump && isGrounded)
        {
            inputJump = Input.GetKeyDown(KeyCode.Space);
        }

        if (inputJump && isGrounded)
        {
            cc.Move(Vector3.up * speed[2]);
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
