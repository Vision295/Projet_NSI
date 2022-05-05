using UnityEngine; // permet d'utiliser des fonctions simples
using UnityEngine.SceneManagement; // permet de changer de scène
public class Début : MonoBehaviour
{
     [SerializeField] // oblige Unity à créer une file privée
     Transform UIPanel; // fait appel à la classe UnityEngine pour connaître la position, la rotation et la taille du panel
    void Start()  
    {
        UIPanel.gameObject.SetActive(true); // s'assure que le panel est activé
    }
 
    public void Restart() 
    {  
        SceneManager.LoadScene("Niveau1"); // charge la scéne du Niveau 1 
    }
}   
