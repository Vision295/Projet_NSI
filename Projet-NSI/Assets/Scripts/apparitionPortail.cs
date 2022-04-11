using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class apparitionPortail : MonoBehaviour
{
    public Epreuve ep;
    public GameObject portail;
    // Start is called before the first frame update
    void Start()
    {
        portail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ep.epreuve == 11)
        {
            portail.SetActive(true);
        } 
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && ep.epreuve == 11)
        {
            SceneManager.LoadScene("Fin de niveau");
        }
    }
}
