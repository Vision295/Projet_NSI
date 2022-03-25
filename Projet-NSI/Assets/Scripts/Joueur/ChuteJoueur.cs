using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChuteJoueur : MonoBehaviour
{
    public Vector3 respawn = new Vector3(0, 3, 0);
    public float offsetY = 0f;
    private CharacterController cc;

    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
    }

    // lorsque le joueur est en dehors des limites de chute
    void Update()
    {
        if(transform.position.y < offsetY)
        {
            cc.enabled = false;
            cc.transform.position = respawn;
            cc.transform.rotation = Quaternion.Euler(0, -90, 0);
            cc.enabled = true;
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
