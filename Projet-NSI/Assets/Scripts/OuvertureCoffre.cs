using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureCoffre : MonoBehaviour
{
    public CalculeScore cs;

    // objets modifi�s par cette fonction
    public GameObject closeChest;
    public GameObject openChest;
    public GameObject gateKey;
    public GameObject arrowGroup;

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
        // si le joueur a tout collect� et est pass� dans le portail
        if (other.tag == "Player")
        {
            closeChest.SetActive(false);
            openChest.SetActive(true);
            gateKey.SetActive(true);

            foreach (Transform child in transform)
            {
                child.transform.Rotate(new Vector3(0, 180, 0));
            }
        }
    }
}
