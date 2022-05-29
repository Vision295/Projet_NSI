using UnityEngine;
using System.Collections; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class Manager : MonoBehaviour 
{
    /*
    script contenu dans toutes les scènes
    script dans l'objet gui - manager
    permet de gérer l'interface utilisateur (GUI)
    */

    [SerializeField]
    Transform UIPanel;
    // variable pour le bouton pause et l'écran de pause
    public Transform pause;
    public bool isPaused;
    public Camera cam;
    private Vector3 posCam;
    private Quaternion rotationCam;
    void Start ()
    {
        // Le menu de pause ne doit pas être affiché lors du lancement de la scène
        if(UIPanel.tag == "Menu")
        {
            UIPanel.gameObject.SetActive(false);
        }
        isPaused = false;
    }
 
    void Update ()
    {
        // si le jeu n'est pas en pause et que le joueur souhaite mettre le jeu en pause alors
        if(Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            Pause();
        }
        // sinon si le joueur appuie sur le touche échappe sort de l'écran de pause
        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            UnPause();
        }
        EventSystem.current.SetSelectedGameObject(null);
    }
    public void AfficherPause()
    {
        UIPanel.gameObject.SetActive(true);
    }
    public void Pause()
    {
        if(!isPaused)
        {
            posCam = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);
            rotationCam = new Quaternion(cam.transform.rotation.x, cam.transform.rotation.y, cam.transform.rotation.z, cam.transform.rotation.w);
            //cam.transform.SetPositionAndRotation(new Vector3(0, 65, 0), Quaternion.Euler(25, -90, 0));
            isPaused = true;
            UIPanel.gameObject.SetActive(true); //turn on the pause menu
            pause.gameObject.SetActive(false);
            Time.timeScale = 0f; //pause the game
        }
    }

    public void UnPause()
    {
        cam.transform.SetPositionAndRotation(posCam, rotationCam);
        isPaused = false;
        pause.gameObject.SetActive(true);
        UIPanel.gameObject.SetActive(false); //turn off pause menu
        Time.timeScale = 1f; //resume game
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif 
        
        Application.Quit();
    }

    public void EcranPrincipal()
    {
        SceneManager.LoadScene("Niveau0");
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static void Hover(GameObject objet)
    {
        // méthode qui permet de modifier (de manière proportionnelle) la taille du bouton lorsque l'utilisateur le survole
        if(objet.tag == "Pause")
        {
            objet.transform.localScale = new Vector3(13, 10, 13);
        } else if(objet.tag == "Restart"){
            objet.transform.localScale = new Vector3(200, 200, 200);
        } else if(objet.tag == "Findeniveau"){
            objet.transform.localScale = new Vector3(20, 20, 20);
        } else if (objet.tag == "Exit"){
            objet.transform.localScale = new Vector3(60, 100, 32);
        } else if (objet.tag == "Menu"){
            objet.transform.localScale = new Vector3(45, 45, 45);
        } else if (objet.tag == "MenuBoutton") {
            objet.transform.localScale = new Vector3(80, 80, 80);
        }
    }

    public static void Unhover(GameObject objet)
    {
        // méthode qui permet à l'objet de récupérer sa taille originale une fois que la souris l'a survolé 
        if(objet.tag == "Pause")
        {
            objet.transform.localScale = new Vector3(10, 10, 10);
        } else if (objet.tag == "Restart") {
            objet.transform.localScale = new Vector3(150, 150, 150);
        } else if(objet.tag == "Findeniveau"){
            objet.transform.localScale = new Vector3(16, 16, 16);
        } else if (objet.tag == "Exit"){
            objet.transform.localScale = new Vector3(45, 100, 25);
        } else if (objet.tag == "Menu") {
            objet.transform.localScale = new Vector3(33, 33, 33);
        } else if (objet.tag == "MenuBoutton") {
            objet.transform.localScale = new Vector3(67, 67, 67);
        }
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Transition");
    }

    public void SkinNotRotate(GameObject objet)
    {
        // méthode lorsque la souris ne survole plus le personnage
        // méthode qui permet de stoper la rotation et l'éclairage du personnage lorsque ce dernier n'est pas survolé par la souris
        objet.transform.Find("Spot Light").GetComponent<Light>().intensity = 0;
        // si l'objet est wall-e
        if(objet.transform.name == "robolaby")
        {
            objet.transform.rotation = Quaternion.Euler(12, 152, 0);
        } 
        // sinon l'objet désélectionné est eve 
        else {
            objet.transform.rotation = Quaternion.Euler(0, -62, 10);
        }
        // stope la rotation
        objet.GetComponent<RotationWallisEtFunua>().enabled = false;
    }

    public void SkinRotate(GameObject objet)
    {
        // méthode lorsque la souris survole le personnage
        // méthode qui permet de faire tourner le personnage sélectionné et de 
        objet.transform.Find("Spot Light").GetComponent<Light>().intensity = 100;
        objet.GetComponent<RotationWallisEtFunua>().enabled = true;
    }

    public void ChangeSound()
    {
        if (MainManager.Instance.son)
        {
            MainManager.Instance.son = false;
        } else 
        {
            MainManager.Instance.son = true;
        }
    }
}
