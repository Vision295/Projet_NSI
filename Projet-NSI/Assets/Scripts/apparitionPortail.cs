using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class apparitionPortail : MonoBehaviour
{
    // script contenu dans l'objet d'arrivé
    public CalculeScore cs;
    public GameObject portail;
    public Findeniveau fin;

    void Start()
    {
        // invisible de base
        portail.SetActive(false);
    }

    void Update()
    {
        // visible lorsque le joueur a tout collecté
        if (cs.epreuve == 11)
        {
            portail.SetActive(true);
        } 
    }
    
    void OnTriggerEnter(Collider other)
    {
        // si le joueur a tout collecté et est passé dans le portail
        if (other.tag == "Player" && cs.epreuve == 11)
        {
            fin.FinNiveau();
            Destroy(gameObject, 0);
        }
    }
}
