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
    
    // à changer
    public float startDelay = 5;
    public float spawnInterval = 5;
    public bool destroy;

    public DeplacementJoueur DJ;
    private float exp;

    void Start()
    { 
        DJ = GetComponent<DeplacementJoueur>();
    }

    // Update is called once per frame
    void PopRandomPF()
    {
        DJ.speed[0] += 0.25f;
        DJ.speed[2] += 0.25f;

        positionX = positionX - 7 * 2 * Mathf.Log(DJ.speed[0], 2);
        positionY = positionY + 4 * Random.Range(-1, 2);
        positionZ = positionZ + Random.Range(1, 3) * Random.Range(-1, 2) * 10;
        Vector3 spawnPosition = new Vector3(positionX, positionY, positionZ);

        PFIndex = Random.Range(0, listePF.Length);
        Instantiate(listePF[PFIndex], spawnPosition, listePF[PFIndex].transform.rotation);
    }

    
    void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        
        if(hit.gameObject.tag == "Plateforme")
        {
            PopRandomPF();
            destroy = true;
            hit.gameObject.tag = "Done";
        }
    }
}
