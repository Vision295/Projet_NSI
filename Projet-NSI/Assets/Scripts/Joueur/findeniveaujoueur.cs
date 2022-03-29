using UnityEngine;
using UnityEngine.SceneManagement;

public class findeniveaujoueur : MonoBehaviour
{
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
