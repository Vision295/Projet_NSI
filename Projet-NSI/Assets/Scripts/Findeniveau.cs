using UnityEngine;
using UnityEngine.SceneManagement;

public class Findeniveau : MonoBehaviour
{
        
    [SerializeField]

    public Transform UIPanel;
    public CollisionJoueur cj;
    public GameObject cam;
    public bool fin;

    void Start()
    {
        UIPanel.gameObject.SetActive(false);
    }
    public void FinNiveau()
    {
        UIPanel.gameObject.SetActive(true);
        fin = true;
        Time.timeScale = 0f;
    }
    public void NiveauSuivant()
    {
        Time.timeScale = 1f;
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Niveau1"))
        {
            SceneManager.LoadScene("Niveau2");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Niveau2"))
        {
            SceneManager.LoadScene("Niveau3");
        }
        else 
        {
            SceneManager.LoadScene("NiveauInfini");
        }
    }
    public void Rejouer()
    {
        Time.timeScale = 1f;
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Niveau1"))
        {
            SceneManager.LoadScene("Niveau1");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Niveau2"))
        {
            SceneManager.LoadScene("Niveau2");
        }
        else 
        {
            SceneManager.LoadScene("Niveau3");
        }
    }      
}