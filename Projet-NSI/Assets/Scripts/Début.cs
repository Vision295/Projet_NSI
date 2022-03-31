using UnityEngine;
using UnityEngine.SceneManagement;
public class Début : MonoBehaviour
{
     [SerializeField]
     Transform UIPanel;
    void Start()
    {
        UIPanel.gameObject.SetActive(true);
    }
 
    public void restart()
    {  
        GameObject button = GameObject.Find("Buttom"); 
        button.SetActive(false);
        SceneManager.LoadScene("Niveau1");
        Time.timeScale = 1f;
    }
}   
