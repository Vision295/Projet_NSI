using UnityEngine; 
using UnityEngine.SceneManagement; // permet de changer de scène

public class findeniveaujoueur : MonoBehaviour
{
    // script pour afficher l'écran de fin de niveau
    
    [SerializeField] 
    public Transform Pause; // fait appel à la classe UnityEngine pour connaître la position, la rotation et la taille du panel

    public bool isPaused; // créer une variable Pause 
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && isPaused) // condition pour pouvoir afficher la scéne de fin de niveau 
        {
            SceneManager.LoadScene("Fin de niveau"); // charge la scène de fin de niveau
        }
    }
}
