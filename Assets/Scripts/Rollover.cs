using UnityEngine;
using UnityEngine.InputSystem;

public class Rollover : MonoBehaviour
{
    public RotateMe rotateMe;
    public bool mouseIsOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //get the distance between the mouse and this transform position
        float Distance = Vector2.Distance(mousePos, transform.position);
        // if the mouse was close enough set a bool to be true
        if (Distance < 1)
        {
            mouseIsOver = true;
            rotateMe.Speed = 0;
        }
        else
        {
            mouseIsOver = false;
            rotateMe.Speed = 100;
        }
    }
}
