using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public PopManager popmanag;
    public GameObject plateforme;
    void Detruit()
    {
        Destroy(plateforme);
    }

    // Update is called once per frame
    void Update()
    {
        plateforme = gameObject;
        if(popmanag.destroy)
        {
            popmanag.destroy = false;
            Invoke("Detruit", 5f);
        }
    }
}
