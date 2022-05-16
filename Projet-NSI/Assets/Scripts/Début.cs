using UnityEngine; 
using UnityEngine.SceneManagement; // permet de charger une scène à partir de la scène actuelle
public class Début : MonoBehaviour
{
     [SerializeField] 
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
