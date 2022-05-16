using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epreuve : MonoBehaviour
{
    private MeshRenderer mesh;
    public Material survole;
    public CalculeScore cs;

    // Start is called before the first frame update
    void Start()
    {
        mesh = gameObject.GetComponent<MeshRenderer>();
        cs.epreuve = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && gameObject.tag != "Done")
        {
            cs.epreuve += 1;
            mesh.material = survole;
            gameObject.transform.tag = "Done";
        }
    }
}
