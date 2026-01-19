using UnityEngine;
using UnityEngine.InputSystem;


public class ColouredShapes : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float t = 0;
    public Sprite[] sprites;

    private int currentSprite = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 1)
        {
            spriteRenderer.color = Random.ColorHSV();
            t = 0;
        }

        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            currentSprite++;
            if (currentSprite >= sprites.Length)
            {
                currentSprite = 0;
            }
        }
        spriteRenderer.sprite = sprites[currentSprite];
    }
}
