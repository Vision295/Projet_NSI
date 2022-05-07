using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChuteJoueur : MonoBehaviour
{
    // vecteur de position de respawn du joueur
    public Vector3 respawn = new Vector3(0, 3, 0);
    // seuil à partir de laquelle le joueur respawn 
    public float offsetY = 0f;
    // component permettant de gérer les déplacements du joueur
    private CharacterController cc;

    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
    }

    // lorsque le joueur est en dehors des limites de chute
    void Update()
    {
        // si le joueur chute
        if(transform.position.y < offsetY)
        {
            // on désactive la restriction du composant et on reset la position du joueur
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
            other.transform.Find("Point Light").GetComponent<Light>().intensity = 10;
        }

        if (other.tag == "Marteau")
        {
            cc.enabled = false;
            cc.transform.position = respawn;
            cc.transform.rotation = Quaternion.Euler(0, -90, 0);
            cc.enabled = true;
        }
    }
}
