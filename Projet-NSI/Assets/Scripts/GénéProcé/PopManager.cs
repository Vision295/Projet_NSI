using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopManager : MonoBehaviour
{
    // liste des plateformes
    public GameObject[] listePF;
    
    // position de la première plateforme à apparaitre
    public float positionX = 95;
    public float positionY = 60;
    public float positionZ = 6;

    // décalage entre les plateformes générées
    public float ecartZ = 10;
    public int PFIndex;
    
    public DeplacementJoueur DJ;
    private float exp;

    // contrôle le joueur
    public CharacterController cc;

    void Start()
    {
        DJ = GetComponent<DeplacementJoueur>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void PopRandomPF()
    {
        DJ.speed[0] += 0.25f;

        positionX -= 14 * Mathf.Log(DJ.speed[0], 2);
        positionY += 4 * Random.Range(-1, 2);
        positionZ += Random.Range(-3, 3) * 5;
        Vector3 spawnPosition = new Vector3(positionX, positionY, positionZ);

        PFIndex = Random.Range(0, listePF.Length);
        Instantiate(listePF[PFIndex], spawnPosition, listePF[PFIndex].transform.rotation);
    }

    
    void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        if(hit.gameObject.tag == "Obstacle")
        {
            hit.gameObject.GetComponent<Rigidbody>().AddForce(cc.velocity * 50);
        }

        if(hit.gameObject.tag == "Plateforme")
        {
            PopRandomPF();
            hit.gameObject.tag = "Done";
        }
    }

    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Plateforme")
        {
            PopRandomPF();
            hit.gameObject.tag = "Done";
        }
    }
}
