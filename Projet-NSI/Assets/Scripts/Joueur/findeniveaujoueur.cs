using UnityEngine;
using UnityEngine.SceneManagement;

public class findeniveaujoueur : MonoBehaviour
{
    // script pour afficher l'écran de fin de niveau
    [SerializeField]
    public Transform Pause;

    public bool isPaused;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && isPaused)
        {
            SceneManager.LoadScene("Fin de niveau");
        }
    }
}
