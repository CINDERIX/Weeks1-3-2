using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float t = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        transform.position = Vector2.Lerp(new Vector2(-5, 0), new Vector2(5, 0), t);
    }
}
