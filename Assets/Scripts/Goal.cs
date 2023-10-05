
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{
     private IEnumerator OnCollisionEnter(Collision other)
     { 
         yield return new WaitForSeconds(1);
         SceneManager.LoadScene("WinScene");
    }
}
