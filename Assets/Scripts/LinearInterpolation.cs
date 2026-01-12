using UnityEngine;

public class LinearInterpolation : MonoBehaviour

{
    public Transform start;
    public Transform end;
    public float t = 0;

    private void Start()
    {

    }

    private void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        
        transform.position = Vector2.Lerp(start.position, end.position, t);

    }


}
