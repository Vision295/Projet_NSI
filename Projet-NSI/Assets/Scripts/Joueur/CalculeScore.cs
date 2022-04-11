using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculeScore : MonoBehaviour
{
    public int score = 0;
    public float endDelay = 10.0f;
    public int epreuve;

    // variable contenant le script de déplacement du joueur
    public DeplacementJoueur DJ;

    // Lorsque le joueur entre en collision avec un objet collectable
    void OnTriggerEnter(Collider other)
    {
        // si c'est un bonus de score
        if (other.tag == "BonusScore")
        {
            score += 1;
        }

        // si c'est un bonus de vitesse
        if (other.tag == "BonusVitesse")
        {
            DJ.speed[0] *= 2;
            Invoke("SpeedBonusEnd", endDelay);
        }
    }

    void SpeedBonusEnd()
    {
        DJ.speed[0] /= 2;
    }
}
