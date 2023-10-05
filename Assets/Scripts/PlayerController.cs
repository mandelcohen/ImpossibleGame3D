
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 0.04f;
    public float jumpForce = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0,forwardSpeed);
        
        bool isKeyDown = Input.GetKeyDown(KeyCode.Space);
        
        if (isKeyDown)// && Can player jump) 
        {
            // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            Rigidbody rigidbody =  GetComponent<Rigidbody>();
            rigidbody.AddForce(0, jumpForce, 0, ForceMode.Impulse);    
        } 
    }
}
