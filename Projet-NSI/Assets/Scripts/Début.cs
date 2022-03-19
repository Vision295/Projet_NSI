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
        SceneManager.LoadScene("SampleScene");
    }
}   
