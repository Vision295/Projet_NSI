using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apparitionPortail : MonoBehaviour
{
    public CalculeScore cs;
    public MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = gameObject.GetComponent<MeshRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (cs.epreuve == 11) {
            //mesh.render = true;
        }
    }
}
