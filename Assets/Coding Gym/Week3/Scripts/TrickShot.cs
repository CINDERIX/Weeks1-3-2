using UnityEngine;
using UnityEngine.InputSystem;

public class TrickShot : MonoBehaviour
{
    public AnimationCurve curve;
    public float t = 0;
    public int speed = 1;

    private bool timerIsRunning = false;
    public bool goingRight = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Keyboard.current.spaceKey.wasPressedThisFrame == true)
        {
            timerIsRunning = true;

            while (timerIsRunning)
            {
                t += Time.deltaTime;

                //transform.position = Vector2.Lerp()

                if (t >= 1)
                {
                    t = 0;
                    timerIsRunning = false;
                }
            }
        }

        if (transform.position.x <= -9) goingRight = true;
        else if (transform.position.x >= 9) goingRight = false;

        if (goingRight)
        {
            transform.position = new Vector2(transform.position.x + Time.deltaTime * 5, 0);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - Time.deltaTime * 5, 0);
        }
    }
    
}
