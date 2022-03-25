using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChuteJoueur : MonoBehaviour
{
    public Vector3 respawn = new Vector3(0, 3, 0);
    public float offsetY = 50f;

    // lorsque le joueur est en dehors des limites de chute
    void Update()
    {
        if(transform.position.y < offsetY)
        {
            transform.position = respawn;
            transform.rotation = Quaternion.Euler(0, -90, 0);
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
