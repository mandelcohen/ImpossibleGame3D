
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 0.1f;
    public float jumpForce = 5;
    public float jumpMovement = -.1f;
    public int fallGravity = -1;
    public float jumpSpin = 2;

    private void FixedUpdate()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>(); 
        if (rigidBody.velocity.y < jumpMovement) 
        { 
            rigidBody.AddForce(0, fallGravity, 0);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Jump(); 
        }
        transform.Translate(0, 0,forwardSpeed * Time.deltaTime, Space.World);
    }
   

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody.AddForce(0, jumpForce, 0);
            rigidBody.angularVelocity = new Vector3(jumpSpin, 0, 0);
        }
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}

