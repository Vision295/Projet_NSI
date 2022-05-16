using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChuteJ : MonoBehaviour
{
    public PopManager pop;
    public Transform fin;
    public Findeniveau fn;

    void Start()
    {
        pop = GetComponent<PopManager>();
        fin.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
    void Update()
    {
        if(transform.position.y < pop.positionY - 10)
        {
            GameOver();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Marteau")
        {
            GameOver();
        }
    }
    void GameOver()
    {
        fin.gameObject.SetActive(true);
        Time.timeScale = 0f;
        fn.fin = true;
    }
}
