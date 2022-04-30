using UnityEngine;
using System.Collections; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour 
{

    [SerializeField]
    Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it
    public Transform pause;

    public bool isPaused; //Used to determine paused state
    public Camera cam;
    private Vector3 posCam;
    private Quaternion rotationCam;
    public string activeSkin;
    void Start ()
    {
        if(UIPanel.tag == "Menu")
        {
            UIPanel.gameObject.SetActive(false); //fait en sorte que le menu ne se voit pas lors du lancement de la scène
        }
        isPaused = false; //make sure isPaused is always false when our scene opens
    }
 
    void Update ()
    {
        //If player presses escape and game is not paused. Pause game. If game is paused and player presses escape, unpause.
        if(Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            Pause();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            UnPause();
        }
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
    public void Restart()
    {
        SceneManager.LoadScene("Niveau1");
        Time.timeScale = 1f;
    }

    public static void hover(GameObject objet)
    {
        if(objet.tag == "Pause")
        {
            objet.transform.localScale = new Vector3(13, 10, 13);
        } else if(objet.tag == "Restart"){
            objet.transform.localScale = new Vector3(200, 200, 200);
        } else if(objet.tag == "Findeniveau"){
            objet.transform.localScale = new Vector3(12, 12, 12);
        } else if (objet.tag == "Exit"){
            objet.transform.localScale = new Vector3(60, 100, 32);
        } else if (objet.tag == "Menu"){
            objet.transform.localScale = new Vector3(45, 45, 45);
        } else {
            objet.transform.localScale = new Vector3(2, 1.67f, 2);
        }
    }

    public static void Unhover(GameObject objet)
    {
        if(objet.tag == "Pause")
        {
            objet.transform.localScale = new Vector3(10, 10, 10);
        } else if (objet.tag == "Restart") {
            objet.transform.localScale = new Vector3(150, 150, 150);
        } else if(objet.tag == "Findeniveau"){
            objet.transform.localScale = new Vector3(10, 10, 10);
        } else if (objet.tag == "Exit"){
            objet.transform.localScale = new Vector3(45, 100, 25);
        } else if (objet.tag == "Menu") {
            objet.transform.localScale = new Vector3(33, 33, 33);
        } else {
            objet.transform.localScale = new Vector3(1.67f, 1.67f, 1.67f);
        }
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Transition");
    } 

    public void SetSkin(GameObject objet)
    {
        activeSkin = objet.transform.name;
    }

    public void SetRotationSkin(GameObject objet)
    {
        objet.transform.Find("Spot Light").GetComponent<Light>().intensity = 0;
        if(objet.transform.name == "robolaby")
        {
            objet.transform.rotation = Quaternion.Euler(12, 152, 0);
        } else {
            objet.transform.rotation = Quaternion.Euler(0, -62, 10);
        }
        objet.GetComponent<RotationWallisEtFunua>().enabled = false;
    }

    public void SkinRotate(GameObject objet)
    {
        objet.transform.Find("Spot Light").GetComponent<Light>().intensity = 100;
        objet.GetComponent<RotationWallisEtFunua>().enabled = true;
    }
}
