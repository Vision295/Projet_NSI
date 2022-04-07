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

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PopRandomPF", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void PopRandomPF()
    {
        positionX = positionX - 25;
        positionY = positionY + 4;
        positionZ = positionZ + Random.Range(-ecartZ, ecartZ);
        Vector3 spawnPosition = new Vector3(positionX, positionY, positionZ);

        PFIndex = Random.Range(0, listePF.Length);
        Debug.Log(positionX);
        Debug.Log(positionY);
        Debug.Log(positionZ);
        Instantiate(listePF[PFIndex], spawnPosition, listePF[PFIndex].transform.rotation);
    }
}
