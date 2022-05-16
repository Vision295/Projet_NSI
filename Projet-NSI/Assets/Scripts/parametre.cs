using UnityEngine; 
using UnityEngine.SceneManagement; // permet de charger une scène à partir de la scène actuelle
public class parametre : MonoBehaviour
{
        [SerializeField] 

        Transform UIPanel; // fait appel à la classe UnityEngine pour connaître la position, la rotation et la taille du panel     
    void Start()
    {
        UIPanel.gameObject.SetActive(true); // s'assure que le panel est activé
    }

    
    public void Quitter ()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // condition pour pouvoir quitter le jeu 
        #endif

        Application.Quit (); // ferme la fenêtre de jeu 
    }
}
