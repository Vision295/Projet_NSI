using UnityEngine;
using UnityEngine.SceneManagement;

public class Findeniveau : MonoBehaviour
{
        
        [SerializeField]

        public Transform UIPanel;
    void Start ()
    {
        UIPanel.gameObject.SetActive(true); 
    }
    public void NiveauSuivant()

    {
       ///if(SceneManager.SetActiveScene('Niveau1'))
      /// {
            SceneManager.LoadScene("Niveau2");
      /// }
        ///else if (SceneManager.SetActiveScene('Niveau2'))
        ///{
            ///SceneManager.LoadScene("Niveau3");
       /// }
        ///else 
        ///{
            ///SceneManager.LoadScene("NiveauInfini");
       /// }
    }
    public void Rejouer()

    {
        ///if(SceneManager.SetActiveScene('Niveau1'))
        ///{
            SceneManager.LoadScene("Niveau1");
        ///}
        ///else if (SceneManager.SetActiveScene('Niveau2'))
        ///{
            ///SceneManager.LoadScene("Niveau2");
       /// }
        ///else 
        ///{
            ///SceneManager.LoadScene("Niveau3");
       /// }
    }

    public void Menu()
    {
        SceneManager.LoadScene("Transition");
    }        
}