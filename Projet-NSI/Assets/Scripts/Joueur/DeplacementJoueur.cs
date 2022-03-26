 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    private float horizontalInput, verticalInput;
    public float[] speed;
    private CharacterController cc;
    private bool isGrounded, inputJump;
    private Vector3 mouvement;
    private float gravity = 9.18f, directionY; 
    
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // regarde cette vidéo : https://www.youtube.com/watch?v=UUJMGQTT5ts&ab_channel=iHeartGameDev

        // Input vertical et horizontal correspond aux flèches du clavier
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Le joueur avance en fonction des inputs horizontaux et verticaux
        mouvement = new Vector3(0, 0, verticalInput * speed[0]);
        mouvement = transform.TransformDirection(mouvement);
        // transform.Rotate(0, horizontalInput * Time.deltaTime, 0);

        // La touche espace (space) pour sauter 
        inputJump = Input.GetKeyDown(KeyCode.Space);
        
        if (inputJump && cc.isGrounded)
        {
            directionY = speed[1];
        }

        directionY -= gravity * Time.deltaTime;
        mouvement.y = directionY;
        cc.Move(mouvement * Time.deltaTime * 5f);
        transform.Rotate(new Vector3(0, horizontalInput, 0));
    }
}