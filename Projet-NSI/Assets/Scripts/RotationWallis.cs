using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotationWallis : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 3, 0);
    }
}
