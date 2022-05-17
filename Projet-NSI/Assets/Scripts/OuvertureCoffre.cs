using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureCoffre : MonoBehaviour
{
    public CalculeScore cs;
    public GameObject closeChest;
    public GameObject openChest;
    public GameObject gateKey;

    // Start is called before the first frame update
    void Start()
    {
        openChest.SetActive(false);
        gateKey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // si le joueur a tout collecté et est passé dans le portail
        if (other.tag == "Player")
        {
            closeChest.SetActive(false);
            openChest.SetActive(true);
            gateKey.SetActive(true);
        }
    }
}
