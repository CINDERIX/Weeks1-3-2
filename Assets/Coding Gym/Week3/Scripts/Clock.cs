using UnityEngine;

public class Clock : MonoBehaviour
{
    public int speed = 10;
    public Vector3 direction;
    public Vector3 position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make a clock hour hand, add a script that makes it rotate at a speed you can set with a public variable
        transform.RotateAround(position, direction, speed * Time.deltaTime);
    }
}
