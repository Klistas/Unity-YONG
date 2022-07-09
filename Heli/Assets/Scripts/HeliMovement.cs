using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeliMovement : MonoBehaviour
{
    private HeliInput _heliInput;
    private Rigidbody _rigidbody;

   
    public float Speed = 2f;
    public float RotationSpeed = 0.5f;
   

    // Start is called before the first frame update
    void Start()
    {
        _heliInput = GetComponent<HeliInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_heliInput.OnButton == true)
        {
            _rigidbody.useGravity = false;

            if (_heliInput.Up)
            {
                _rigidbody.AddForce(0f, Speed, 0f);

            }
            if (_heliInput.Down)
            {
                _rigidbody.AddForce(0f, -Speed, 0f);

            }
            if (_heliInput.Left)
            {
                transform.Rotate(new Vector3(0, -RotationSpeed, 0)); 

            }
            if (_heliInput.Right)
            {

                transform.Rotate(new Vector3(0, RotationSpeed, 0)); 
            }

        }
        else
        {
            _rigidbody.useGravity = true; 
        }
    }
}
