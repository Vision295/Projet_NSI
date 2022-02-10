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
<<<<<<< HEAD

        if (other.tag == "BonusVitesse")
        {
            DJ.speed[0] *= 2;
        }
=======
>>>>>>> 34d09fb08d6e286f8a243a9381e03cc71158e395
    }
}
