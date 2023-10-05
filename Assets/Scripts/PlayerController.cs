
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 0.1f;
    public float jumpForce = 5;
    public int fallFaster = -1;

    private void FixedUpdate()
    {
        {
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            if (rigidbody.velocity.y < -.1f)
            {
                rigidbody.AddForce(0, fallFaster, 0);
            }
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody.AddForce(0, jumpForce, 0);    
        } 
        transform.Translate(0, 0,forwardSpeed);
    }
}
