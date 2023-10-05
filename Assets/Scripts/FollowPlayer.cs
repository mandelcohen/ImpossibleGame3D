using System;
using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    private void LateUpdate()
    {
        GameObject player = gameObject.Find("Player");
        Vector3 target = player.transform.position + new Vector3(0, 5, -5);
        transform.position = target;
    }
}
