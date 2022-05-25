using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureCoffre : MonoBehaviour
{
    public CalculeScore cs;

    // objets modifiés par cette fonction
    public GameObject closeChest;
    public GameObject openChest;
    public GameObject gateKey;
    public GameObject fleches1;
    public GameObject fleches2;

    // Start is called before the first frame update
    void Start()
    {
        openChest.SetActive(false);
        gateKey.SetActive(false);
        fleches2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            closeChest.SetActive(false);
            openChest.SetActive(true);
            gateKey.SetActive(true);
            fleches1.SetActive(false);
            fleches2.SetActive(true);
        }
    }
}
