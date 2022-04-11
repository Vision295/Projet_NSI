using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChuteJ : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < 0)
        {
            SceneManager.LoadScene("NiveauInfini");
        }
    }
}
