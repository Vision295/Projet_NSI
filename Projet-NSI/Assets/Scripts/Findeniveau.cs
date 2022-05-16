using UnityEngine; 
using UnityEngine.SceneManagement; // permet de charger une scène à partir de la scène actuelle

public class Findeniveau : MonoBehaviour
{
        
    [SerializeField] 

    public Transform UIPanel; // fait appel à la classe UnityEngine pour connaître la position, la rotation et la taille du panel
    public CollisionJoueur cj; // fait appel au script CollisionJoueur
    public GameObject cam; // fait appel à l'objet caméra 
    public bool fin; // création d'une variable fin 

    void Start()
    {
        UIPanel.gameObject.SetActive(false); // s'assure que le panel est inactif
    }
    public void FinNiveau()
    {
        UIPanel.gameObject.SetActive(true); // s'assure que le panel est activé
        fin = true;
        Time.timeScale = 0f; // initialise le temps à 0
    }
    public void NiveauSuivant()
    {
        Time.timeScale = 1f; // initialise le temps à 1
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Niveau1")) // détermine la scéne active et selon la scène active on charge la scéne suivante
        {
            SceneManager.LoadScene("Niveau2"); // charge la scéne du niveau 2
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Niveau2")) // détermine la scéne active et selon la scène active on charge la scéne suivante
        {
            SceneManager.LoadScene("Niveau3"); // charge la scéne du niveau 3
        }
        else 
        {
            SceneManager.LoadScene("NiveauInfini"); // charge la scéne du niveau infini 
        }
    }
    public void Rejouer()
    {
        Time.timeScale = 1f; // initialise le temps à 1
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Niveau1")) // détermine la scéne active et selon la scène active on charge cette derniére
        {
            SceneManager.LoadScene("Niveau1"); // charge la scène du niveau 1
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Niveau2")) // détermine la scéne active et selon la scène active on charge cette derniére
        {
            SceneManager.LoadScene("Niveau2"); // charge la scène du niveau 2
        }
        else 
        {
            SceneManager.LoadScene("Niveau3"); // charge la scène du niveau 3
        }
    }      
}