
using System;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 0.04f;
    public float jumpForce = 5;
    public float moreGravity = .1f;

    private void FixedUpdate()
    {
        {
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            if (rigidbody.velocity.y < moreGravity)
            {
                rigidbody.AddForce(0, moreGravity, 0);
            }
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody rigidbody =  GetComponent<Rigidbody>();
            rigidbody.AddForce(0, jumpForce, 0);    
        } 
        transform.Translate(0, 0,forwardSpeed);
    }
}
