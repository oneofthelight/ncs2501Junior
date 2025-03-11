using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinePropeller : MonoBehaviour
{
    public GameObject Propeller;
    public float rotationSpeed = 300;
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
