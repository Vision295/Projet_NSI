using UnityEngine;
using System.Collections; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour 
{

    [SerializeField]
    Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it

    [SerializeField]
    Text timeText; //Will assign our Time Text to this variable so we can modify the text it displays.

    public bool isPaused; //Used to determine paused state

    void Start ()
    {
        UIPanel.gameObject.SetActive(false); //fait en sorte que le menu ne se voit pas lors du lancement de la scène
        isPaused = false; //make sure isPaused is always false when our scene opens
        
    }

    void Update ()
    {

        timeText.text = "Time since sartup : " + Time.timeSinceLevelLoad; //Tells us the time since the scene loaded

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

    public void Pause()
    {
        isPaused = true;
        UIPanel.gameObject.SetActive(true); //turn on the pause menu
        Time.timeScale = 0f; //pause the game
    }

    public void UnPause()
    {
        isPaused = false;
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
        SceneManager.LoadScene(0);   
    }
}
