using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class SpriteChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    private int randomNumber = 0;
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

            if (barrels.Count > 0)
            {
                PickARandomSprite();

            }
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

        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0) 
        {
            barrels.RemoveAt(0);
        
        }

    }

    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite() 
    {
        //pick a random number
        randomNumber = Random.Range(0, barrels.Count);
        spriteRenderer.sprite = barrels[randomNumber];
    }

}
