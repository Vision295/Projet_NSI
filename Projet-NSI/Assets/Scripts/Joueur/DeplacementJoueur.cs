 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    public float horizontalInput, verticalInput;
    public float[] speed;
    private CharacterController cc;
    public bool trampo, inputJump;
    private Vector3 mouvement;
    private float gravity = 9.18f, directionY; 
    public Findeniveau fn;
    
    // Start est appellé avnt la premiére mise à jour des frames 
    void Start()
    {
        cc = GetComponent<CharacterController>();
        Application.targetFrameRate = 60;
    }

    // Update est appellé une fois par frame 
    void Update()
    {

        // Input vertical et horizontal correspond aux flèches du clavier
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Le joueur avance en fonction des inputs horizontaux et verticaux via un vecteur de déplacement : mouvement
        mouvement = new Vector3(0, 0, verticalInput * speed[0]);
        mouvement = transform.TransformDirection(mouvement);

        // La touche espace (space) pour sauter 
        inputJump = Input.GetKeyDown(KeyCode.Space);
        
        if ((inputJump && cc.isGrounded) || trampo)
        {
            directionY = speed[1];
        }
        // on applique la gravité
        directionY -= gravity * Time.deltaTime;
        mouvement.y = directionY;
        // on applique le mouvement au joueur
        cc.Move(mouvement * Time.deltaTime * 5f);

        // si c'est la fin du niveau
        if(!fn.fin)
        {
            transform.Rotate(new Vector3(0, horizontalInput * speed[2], 0));
        }
    }
}