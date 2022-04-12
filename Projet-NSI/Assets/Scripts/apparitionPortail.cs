using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class apparitionPortail : MonoBehaviour
{
    public CalculeScore cs;
    public GameObject portail;
    public Findeniveau fin;

    // Start is called before the first frame update
    void Start()
    {
        portail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (cs.epreuve == 11)
        {
            portail.SetActive(true);
        } 
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && cs.epreuve == 11)
        {
            fin.FinNiveau();
        }
    }
}
