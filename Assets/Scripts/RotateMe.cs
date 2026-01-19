using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public int Speed = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(0, 0, Speed * Time.deltaTime);
        transform.Rotate(rotation);

    }
}
