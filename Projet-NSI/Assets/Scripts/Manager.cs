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
    void Start ()
    {
        if(UIPanel.tag == "Menu")
        {
            UIPanel.gameObject.SetActive(false); //fait en sorte que le menu ne se voit pas lors du lancement de la scène
        }
        isPaused = false; //make sure isPaused is always false when our scene opens
        //pause.gameObject.SetActive(true);
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
            objet.transform.localScale = new Vector3(20, 20, 20);
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
            objet.transform.localScale = new Vector3(16, 16, 16);
        } else {
            objet.transform.localScale = new Vector3(1.67f, 1.67f, 1.67f);
        }
    }
}
