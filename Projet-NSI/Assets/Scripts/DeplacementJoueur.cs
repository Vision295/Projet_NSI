using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    private float horizontalInput, verticalInput;
    private float[] speed =  {5f, 5f, 3.5f};
    private CharacterController cc;
    private bool isGrounded, inputJump;
    private Vector3 mouvement;
    private float gravity = 9.18f, directionY; 
    
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
        mouvement = new Vector3(horizontalInput, 0, verticalInput);
        // transform.Rotate(0, horizontalInput * Time.deltaTime, 0);

        // La touche espace (space) pour sauter 
        // teser le cc.isGrounded !!!!!!
        inputJump = Input.GetKeyDown(KeyCode.Space);
        
        if (inputJump)
        {
            directionY = speed[2];
        }
        directionY -= gravity * Time.deltaTime;
        mouvement.y = directionY;
        Debug.Log(mouvement.y);
        cc.Move(mouvement * Time.deltaTime * 5f);
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
