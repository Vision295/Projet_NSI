using UnityEngine;
using UnityEngine.SceneManagement;

public class findeniveau : MonoBehaviour
{
        
        [SerializeField]

        Transform UIPanel;
    void Start ()

    {
        UIPanel.gameObject.SetActive(true); 
    }
    public void OnMouseUpAsButton()

    {
        SceneManager.LoadScene("Niveau2");     
    }
    public void OnMouseUpAsButton2()

    {
        SceneManager.LoadScene("Niveau1");
    }

    public void OnMouseUpAsButton3()
    {
        SceneManager.LoadScene("SampleScene");
    }        
}