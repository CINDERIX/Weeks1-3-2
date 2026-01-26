using UnityEngine;
using UnityEngine.InputSystem;

public class Cat : MonoBehaviour
{
    public GameObject wholecat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float Distance = Vector2.Distance(mousePos, transform.position);

        if (Distance < 1)
        {
            float flattenAmount = Mathf.Lerp(0, 0.5f, 1 - Distance); // Calculate flatten amount based on distance
            wholecat.transform.localScale = new Vector3 (1 + flattenAmount, 1 - flattenAmount, 1);
            wholecat.transform.position = new Vector3(transform.position.x, transform.position.y - flattenAmount*3, transform.position.z);
        }
    }
}
