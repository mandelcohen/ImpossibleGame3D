using System;
using UnityEngine;


public class FollowPlayer : MonoBehaviour 
{
    private void LateUpdate()
    { 
        GameObject player = GameObject.Find("Player");
        Vector3 target = player.transform.position + new Vector3(0, 2.5f, -5);
        transform.position = target;
    }
}


