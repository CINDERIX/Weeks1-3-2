using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels = new Sprite[3];

    public int randomNumber = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();
        //spriteRenderer.sprite = mySprite;
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            //PickARandomColor();
            PickARandomSprite();
        }

        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is the mouse over the sprite?
        if (spriteRenderer.bounds.Contains(mousePos))
        {
            //Y: set the color to our col variable
            spriteRenderer.color = col;
        }
        else
        {
            //N: set the color to white
            spriteRenderer.color = Color.white;
        }
    }

    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite() 
    {
        //pick a random number
        randomNumber = Random.Range(0, barrels.Length);
        ////assign that sprite
        //if (randomNumber == 0)
        //{
        //    spriteRenderer.sprite = barrel0;
        //}
        //else if (randomNumber == 1)
        //{
        //    spriteRenderer.sprite = barrel1;
        //}
        //else if (randomNumber == 2)
        //{
        //    spriteRenderer.sprite = barrel2;
        //}   

        spriteRenderer.sprite = barrels[randomNumber];
    }

}
