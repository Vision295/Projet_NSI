using UnityEngine; // permet d'utiliser des fonctions simples
using UnityEngine.SceneManagement; // permet de changer de scène 

public class Transition : MonoBehaviour
{
        [SerializeField] // oblige Unity à créer une file privée 

        Transform UIPanel; // fait appel à la classe UnityEngine pour connaître la position, la rotation et la taille du panel
    void Start()
    {
        UIPanel.gameObject.SetActive(true); // s'assure que le panel est activé
    }

    public void Niveau1() 
    {
        SceneManager.LoadScene("Niveau1"); //charge la scène du niveau 1
    }

    public void Niveau2()
    {
        SceneManager.LoadScene("Niveau2"); // charge la scène du niveau 2
    }

    public void Niveau3() 
    {
        SceneManager.LoadScene("Niveau3"); // charge la scène du niveau 3
    }

    public void Niveauinfini()
    {
        SceneManager.LoadScene("NiveauInfini"); // charge la scène du niveau infini
    }
}
