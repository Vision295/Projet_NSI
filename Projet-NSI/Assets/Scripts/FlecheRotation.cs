using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlecheRotation : MonoBehaviour
{
    public CalculeScore cs;
    public GameObject fleches1;
    public GameObject fleches2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cs.epreuve == 11)
        {
            fleches1.SetActive(true);
            fleches2.SetActive(false);
        }
    }
}
