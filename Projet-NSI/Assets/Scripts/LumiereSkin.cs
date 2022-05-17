using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LumiereSkin : MonoBehaviour
{
    public MainManager MM;

    // Update is called once per frame
    void Update()
    {
        if(MM.activeSkin == "robolaby" && transform.name == "robolaby")
        {
            transform.Find("Spot Light (1)").GetComponent<Light>().intensity = 100;
        } else if (MM.activeSkin == "futuna" && transform.name == "robolaby") 
        {
            transform.Find("Spot Light (1)").GetComponent<Light>().intensity = 0;
        } else if(MM.activeSkin == "futuna" && transform.name == "futuna") 
        {
            transform.Find("Spot Light (1)").GetComponent<Light>().intensity = 100;
        } else if (MM.activeSkin == "robolaby" && transform.name == "futuna") 
        {
            transform.Find("Spot Light (1)").GetComponent<Light>().intensity = 0;
        }
    }
}
