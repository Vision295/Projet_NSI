using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopManager : MonoBehaviour
{
    public GameObject[] listePF;
    public float positionX = 95;
    public float positionY = 60;
    public float positionZ = 6;
    public float ecartZ = 10;
    public float startDelay = 5;
    public float spawnInterval = 5;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("PopRandomPF", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void PopRandomPF(GameObject précédente)
    {
        // positionX = positionX - 25;
        // positionY = positionY + 8*Random.Range(0, 1)-4;
        // positionZ = positionZ + Random.Range(-ecartZ, ecartZ);
        // Vector3 spawnPosition = new Vector3(positionX, positionY, positionZ);

        // PFIndex = Random.Range(0, listePF.Length);
        // Instantiate(listePF[PFIndex], spawnPosition, listePF[PFIndex].transform.rotation);
    }
}
