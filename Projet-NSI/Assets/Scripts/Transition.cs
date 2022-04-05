using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
        [SerializeField]

        Transform UIPanel; 
    void Start()
    {
        UIPanel.gameObject.SetActive(true);
    }

    public void Niveau1() 
    {
        SceneManager.LoadScene("Niveau1");
    }

    public void Niveau2()
    {
        SceneManager.LoadScene("Niveau2"); 
    }

    public void Niveau3() 
    {
        SceneManager.LoadScene("Niveau3");
    }

    public void Niveauinfini()
    {
        SceneManager.LoadScene("Niveau infini");
    }   


}
