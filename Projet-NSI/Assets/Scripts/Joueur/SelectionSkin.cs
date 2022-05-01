using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSkin : MonoBehaviour
{
    // script qui permet au joueur d'avoir un skin
    public string activeSkin;
    void Start()
    {
        activeSkin = MainManager.Instance.activeSkin;
        if(activeSkin == transform.name)
        {
            // supression du skin futuna
            Destroy(gameObject.transform.GetChild(24).gameObject);
        } else {
            //supression du skin wallis
            for(int i = 0; i < 22; i++)
            {
                Destroy(gameObject.transform.GetChild(i).gameObject);
            }
        }
    }
}
