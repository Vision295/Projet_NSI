using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
        [SerializeField]

        Transform UIPanel; 
    void Start()
    {
        UIPanel.gameObject.SetActive (true);
    }

    public void OnMouseUpAsButton() 
    {
        SceneManager.LoadScene("Niveau1");
    }

    public void OnMouseUpAsButton2()
    {
        SceneManager.LoadScene("Niveau2"); 
    }

    public void OnMouseUpAsButton3() 
    {
        SceneManager.LoadScene("Niveau3");
    }    
}
