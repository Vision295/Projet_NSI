using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSkin : MonoBehaviour
{
    public string activeSkin;
    void Start()
    {
        activeSkin = MainManager.Instance.activeSkin;
        if(activeSkin == transform.name)
        {
            Debug.Log("Wallis");
            Destroy(gameObject.transform.GetChild(24).gameObject);
        } else {
            for(int i = 0; i < 22; i++)
            {
                Destroy(gameObject.transform.GetChild(i).gameObject);
            }
        }
    }
}
