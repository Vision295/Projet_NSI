using UnityEngine;
using UnityEngine.SceneManagement;
public class Début : MonoBehaviour
{
     [SerializeField]
     Transform UIPanel;
    void Start()
    {
        UIPanel.gameObject.SetActive(true);
        GameObject button = GameObject.Find("Button"); 
        button.SetActive(false);
        Time.timeScale = 1f;
    }
 
    public void Restart()
    {  
        SceneManager.LoadScene("Niveau1");
    }
}   
