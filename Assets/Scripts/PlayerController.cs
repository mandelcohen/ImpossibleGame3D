
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 0.1f;
    public float jumpForce = 5;
    public float fallTolerance = -.1f;
    public int fallGravity = -1;
    public float jumpSpin = 2;

    private void FixedUpdate()
    {
        // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>(); 
        if (rigidBody.velocity.y < fallTolerance) 
        { 
            rigidBody.AddForce(0, fallGravity, 0);
        }

        rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, forwardSpeed);
    } 

    void Update()
    {
        if (Input.GetButton("Jump") && IsTouchingGround())
        {
            Jump(); 
        }
    }
   

    private void Jump()
    {
            // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        Vector3 velocity = rigidBody.velocity;
        velocity.y = jumpForce;
        rigidBody.velocity = velocity;
        rigidBody.angularVelocity = new Vector3(jumpSpin, 0, 0);
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}

