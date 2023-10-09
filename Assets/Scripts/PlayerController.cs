
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 0.1f;
    public float jumpForce = 5;
    public int fallFaster = -1;

    private void FixedUpdate()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>(); 
        if (rigidBody.velocity.y < -.1f) 
        { 
            rigidBody.AddForce(0, fallFaster, 0);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Jump(); 
        }
        transform.Translate(0, 0,forwardSpeed, Space.World);
    }
   

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody.AddForce(0, jumpForce, 0);
            rigidBody.angularVelocity = new Vector3(2, 0, 0);
        }
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}

