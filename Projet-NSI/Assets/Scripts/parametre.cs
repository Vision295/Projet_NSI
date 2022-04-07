using UnityEngine;
using UnityEngine.SceneManagement;
public class parametre : MonoBehaviour
{
        [SerializeField]

        Transform UIPanel;     
    void Start()
    {
        UIPanel.gameObject.SetActive(true);
    }

    
    public void Quitter ()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

        Application.Quit (); 
    }
}
