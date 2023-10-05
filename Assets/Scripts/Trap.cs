using System.Collections;
using UnityEngine;

public class Trap : MonoBehaviour
{
    IEnumerator OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        yield return new WaitForSeconds(2);
    }
}
