
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(1, 1, 1);
    }

    public void HoverStart()
    {
        transform.localScale = Vector3.one * 1.1f;
    }
        
    public void HoverEnd()
    {
        transform.localScale = Vector3.one;
    }
        
    public void ClickStart()
    {
        var mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.magenta;
        mr.material.SetColor("Color", Color.magenta);
    }
    public void ClickEnd()
    {
        var mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.white;
        mr.material.SetColor("ColorEmission", Color.white);
    }

    public void Click()
    {
        SceneManager.LoadScene("GameScene");
    }
}