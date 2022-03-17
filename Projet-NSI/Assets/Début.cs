using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Début : MonoBehaviour
{
     [SerializeField]
     Transform UIPanel;
    void Start()
    {
        UIPanel.gameObject.SetActive(true);
    }
    public void Laby ()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = true;
       
        #endif 
    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}   
