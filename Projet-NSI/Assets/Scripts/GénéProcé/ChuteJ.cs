using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChuteJ : MonoBehaviour
{
    public PopManager pop;

    void Start()
    {
        pop = GetComponent<PopManager>();
    }
    void Update()
    {
        if(transform.position.y < pop.positionY - 10)
        {
            SceneManager.LoadScene("NiveauInfini");
        }
    }
}
