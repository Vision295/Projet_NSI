using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationWallisEtFunua : MonoBehaviour
{
    /* 
    script dans la scène niveau 0
    script dans les objets robolaby et futuna
    script utilisée pour faire tourner les différents skins lors de la séléction 
    */
     void Update()
    {
        transform.Rotate(0, 3, 0);
    }
}
