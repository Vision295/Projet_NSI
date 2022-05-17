using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // variable qui stocke l'objet qui ne se détruira pas
    public static MainManager Instance;

    // skin séléctionné
    public string activeSkin;

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

    public void ChangeSound(GameObject sound, GameObject son, GameObject sonCoupe)
    {
        if(sound.GetComponent<AudioSource>().volume == 0)
        {
            sound.GetComponent<AudioSource>().volume = 1;
            foreach (Transform child in son.transform)
            {
                child.GetComponent<Renderer>().enabled = false;
            }
            foreach (Transform child in sonCoupe.transform)
            {
                child.GetComponent<Renderer>().enabled = true;
            }
        } else {
            sound.GetComponent<AudioSource>().volume = 0;
            foreach (Transform child in son.transform)
            {
                child.GetComponent<Renderer>().enabled = true;
            }
            foreach (Transform child in sonCoupe.transform)
            {
                child.GetComponent<Renderer>().enabled = false;
            }
        }
    }

}
