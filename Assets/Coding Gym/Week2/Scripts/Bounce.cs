using UnityEngine;

public class Bounce : MonoBehaviour
{

    public float t = 0;
    public AnimationCurve curve;
    public bool goingRight = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // bounce the object up and down using an animation curve
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        float y = curve.Evaluate(t) * 5 - 4;
        // bounces ball when reaching edges
        if (transform.position.x <= -9) goingRight = true;
        else if (transform.position.x >= 9) goingRight = false;

        if (goingRight)
        {
            transform.position = new Vector2(transform.position.x + Time.deltaTime * 5, y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - Time.deltaTime * 5, y);
        }

        transform.position = new Vector2(transform.position.x, y);


    }
}
