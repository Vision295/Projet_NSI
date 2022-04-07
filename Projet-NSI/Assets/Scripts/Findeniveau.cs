using UnityEngine;
using UnityEngine.SceneManagement;

public class findeniveau : MonoBehaviour
{
        
        [SerializeField]

        public Transform UIPanel;
    void Start ()
    {
        UIPanel.gameObject.SetActive(true); 
    }
    public void NiveauSuivant()

    {
        SceneManager.LoadScene("Niveau2");
    }
    public void Rejouer()

    {
        SceneManager.LoadScene("Niveau1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("SampleScene");
    }        
}