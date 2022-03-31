using UnityEngine;
using UnityEngine.SceneManagement;
public class Début : MonoBehaviour
{
     [SerializeField]
     Transform UIPanel;
    void Start()
    {
        UIPanel.gameObject.SetActive(true);
        GameObject button = GameObject.Find("Buttom"); 
        button.SetActive(false);
    }
 
    public void restart()
    {  
        SceneManager.LoadScene("Niveau1");
        Time.timeScale = 1f;
    }
}   
