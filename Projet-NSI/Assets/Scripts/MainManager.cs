using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // variable qui stocke l'objet qui ne se détruira pas
    public static MainManager Instance;

    // skin séléctionné
    public string activeSkin;
    public bool son = true;

    void Start()
    {
        Application.targetFrameRate = 60;
    }
    private void Awake()
    {
        // méthode pour que l'objet MainManager ne soit pas détruit lors du changement de scène
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetSkin(GameObject objet)
    {
        // méthode pour sélectionner le skin
        activeSkin = objet.transform.name;
    }

    void Update()
    {
        if(son)
        {
            GetComponent<AudioSource>().volume = 0.35f;
        } else 
        {
            GetComponent<AudioSource>().volume = 0;
        }
    }
}
