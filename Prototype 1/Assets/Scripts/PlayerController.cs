using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool _forward = false;
    public float _speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_forward) {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        } else {
            transform.Translate(Vector3.zero);
        }

        // Move the vehicle forward
        if(Input.GetKeyDown(KeyCode.W)) {
            _forward = true;
        }

        if(Input.GetKeyUp(KeyCode.W)) {
            _forward = false;
        } 
        
        
    }
}
