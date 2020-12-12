using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController2D characterController;

    public float moveSpeed = 40f;
    private float horizontal;

    private bool jump = false;
    private bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }

        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        
    }

    void FixedUpdate()
    {
        characterController.Move(horizontal * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
