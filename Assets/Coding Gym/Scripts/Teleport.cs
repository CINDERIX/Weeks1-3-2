using System.Threading;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 3) {
            transform.position = new Vector2(Random.Range(-9f, 9f), Random.Range(-9f, 9f));
            t = 0;  
        }
  
        //waits 3 seconds

    }
}
