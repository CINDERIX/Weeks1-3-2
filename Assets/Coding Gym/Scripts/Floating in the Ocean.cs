using UnityEngine;

public class FloatingInTheOcean : MonoBehaviour
{
    public float t = 0;
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 1) {
            t = 0;
        }

        transform.position = new Vector2(transform.position.x, curve.Evaluate(t*2));
    }
}
