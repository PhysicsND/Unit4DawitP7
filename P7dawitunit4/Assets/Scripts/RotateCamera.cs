using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
