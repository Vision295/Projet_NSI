using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculeScore : MonoBehaviour
{
    public int score = 0; // creation d'une variable score 
    public float endDelay = 10.0f; // creation d'une variable pour le temps 
    public int epreuve; 
    public float acceleration = 1.5f;

    // variable contenant le script de déplacement du joueur
    public DeplacementJoueur DJ;
    public GameObject Tm, Ttm;
    private TextMesh tm, ttm;

    void Start()
    {
        tm = Tm.GetComponent<TextMesh>(); 
        ttm = Ttm.GetComponent<TextMesh>(); 
    }

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
            DJ.speed[0] *= acceleration;
            // met fin au bonus au bon d'un certain temps
            Invoke("SpeedBonusEnd", endDelay);
        }
        if (other.tag == "Key")
        {
            epreuve = 11;
        }
    }

    void SpeedBonusEnd()
    {
        DJ.speed[0] /= acceleration; // divise la vitesse du joueur par l'accélération
    }

    void Update()
    {
        ttm.text = "score " + score.ToString(); 
        tm.text = "score " + score.ToString(); 
    }
}
