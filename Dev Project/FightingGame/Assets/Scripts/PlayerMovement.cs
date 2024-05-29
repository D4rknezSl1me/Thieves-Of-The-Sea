using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 30f;

    float horizontalMove = 0;
    bool jump = false;
    public bool crouch = false;


    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetBool("Crouching", crouch);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        animator.SetBool("Jumping", !controller.m_Grounded);

        if (Input.GetButtonDown("Jump")) 
        { 
            jump = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    private void FixedUpdate()
    {
        //Move Character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
