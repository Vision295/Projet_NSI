using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculeScore : MonoBehaviour
{
    public int score = 0;
    public DeplacementJoueur DJ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BonusScore")
        {
            score += 1;
        }

        if (other.tag == "BonusVitesse")
        {
            DJ.speed[0] *= 2;
        }
    }
}