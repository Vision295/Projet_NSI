using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebutNiveau : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            Time.timeScale = 1;
            GetComponent<MeshRenderer>().enabled = false;
            transform.Find("cadre").GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
