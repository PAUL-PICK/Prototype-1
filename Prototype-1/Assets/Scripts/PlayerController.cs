using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _forwardInput;
    private float _horizontalInput;
    private float _speed = 25.0f;
    private float _turnSpeed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {// move forward
        _forwardInput = Input.GetAxisRaw("Vertical");
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        // moves player  backwards and forward with vertical input
        transform.Translate(_speed * Time.deltaTime * Vector3.forward * _forwardInput);
        // moves player left and right with horizontakl input
        transform.Rotate(_horizontalInput * _turnSpeed * Time.deltaTime * Vector3.up);
    }
}
