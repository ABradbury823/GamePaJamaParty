using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{

    public GameObject box;
    public GameObject door;
    private bool pressed = false;
    public static Vector3 originalPos;

    // Vectors to move the button
    private Vector3 downShift = new Vector3(0f, -0.1f);

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void boxContact()
    {
        if (!pressed) // Check if the button was already pressed
        {
            pressed = true;
            transform.position = transform.position + downShift;
        }
    }

    void boxRelease()
    {
        if (pressed) // Check to see if the button was already pressed
        {
            pressed = false;
            transform.position = originalPos;
        }
    }
}
