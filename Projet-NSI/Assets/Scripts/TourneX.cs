using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourneX : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
    }
}
