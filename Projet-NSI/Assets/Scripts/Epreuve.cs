using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epreuve : MonoBehaviour
{
    private MeshRenderer mesh;
    public Material survole;
    public int epreuve;

    // Start is called before the first frame update
    void Start()
    {
        mesh = gameObject.GetComponent<MeshRenderer>();
        epreuve = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && gameObject.tag != "Done")
        {
            mesh.material = survole;
            gameObject.transform.tag = "Done";
            epreuve += 1;
        }
    }
}
