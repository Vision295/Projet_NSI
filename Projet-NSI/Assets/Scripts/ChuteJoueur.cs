using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChuteJoueur : MonoBehaviour
{
    private Vector3 respawn = new Vector3(0, 3, 0);
    public float offsetY = -10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < offsetY)
        {
            transform.position = respawn;
            SceneManager.LoadScene("SampleScene");       
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            respawn = other.transform.position + new Vector3(0, 3, 0);
        }
    }
}
