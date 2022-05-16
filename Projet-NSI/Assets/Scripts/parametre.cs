using UnityEngine; // permet d'utiliser des fonctions simples
using UnityEngine.SceneManagement; // permet de changer de scène 
public class parametre : MonoBehaviour
{
        [SerializeField] // oblige Unity à créer une file privée

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
