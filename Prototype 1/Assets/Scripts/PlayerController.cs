using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _speed;
    public float _turnSpeed;

    public float _horizontalInput;
    public float _verticalInput;

    // Update is called once per frame
    void Update()
    {
        // Get input to move the vehicle
        _horizontalInput = Input.GetAxis("Horizontal");   
        _verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);            
        //transform.Translate(Vector3.right * Time.deltaTime * _turnSpeed * _horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * _turnSpeed * _horizontalInput);
    }
}
