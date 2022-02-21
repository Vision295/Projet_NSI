using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChuteJoueur : MonoBehaviour
{
    private Vector3 respawn = new Vector3(0, 3, 0);
    public float offsetY = -10f;

    // lorsque le joueur est en dehors des limites de chute
    void Update()
    {
        if(transform.position.y < offsetY)
        {
            transform.position = respawn;
        }
    }

    // lorsque le joueur entre en collision avec un checkpoint
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            respawn = other.transform.position + new Vector3(0, 3, 0);
        }
    }
}
