using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class RollOver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool timer = false;
    Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    public float t = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        if (Vector2.Distance(mousePosition, new Vector2(transform.position.x, transform.position.y) <= ))
        {
            timer = true;
        }

        while (timer) { 
            t += Time.deltaTime;
        }
    }
}
