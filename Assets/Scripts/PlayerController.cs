using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isKeyDown = Input.GetKeyDown(KeyCode.Escape);
        
        transform.Translate(0, 0,speed);
    }
}
