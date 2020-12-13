using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{

    public GameObject box;
    public GameObject door;
    public GameObject buttonParent;
    private bool pressed = false;
    public static Vector3 originalPos;
    private float rayHeight = 0.35f;


    // Vectors to move the button and cast rays
    private Vector3 downShift = new Vector3(0f, -0.05f);
    

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector2.up * rayHeight);
        RaycastHit2D hit = Physics2D.Raycast(originalPos, Vector2.up, rayHeight);


        // Consider adding more RaycastHit2D variables with an adjusted first variable
        // to cover more of the button's width.
        if (hit.collider != null)
        {
            if (!pressed) // Check if the button was already pressed
            {
                boxContact();
            }
            
        }
        else // Nothing is on top of the button
        {
            boxRelease();
        }

    }

    /*
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.transform.IsChildOf(buttonParent.transform))
        {
            boxContact();
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (!collision.transform.IsChildOf(buttonParent.transform))
        {
            boxRelease();
        }
    }
    */

    void boxContact()
    {
        if (!pressed)
        {
            pressed = true;
            transform.position = originalPos + downShift;
            door.SetActive(false);
        }
    }

    void boxRelease()
    {
        if (pressed)
        {
            pressed = false;
            transform.position = originalPos;
            door.SetActive(true);
        }
    }
}
