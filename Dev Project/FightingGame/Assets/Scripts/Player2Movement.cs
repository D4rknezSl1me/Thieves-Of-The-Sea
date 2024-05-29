using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class Player2Movement : MonoBehaviour
{
    public Character2Controller2D controller;
    public Animator animator;
    public float runSpeed = 30f;

    float horizontalMove = 0;
    bool jump = false;
    public bool crouch = false;


    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal2") * runSpeed;

        animator.SetBool("Crouching", crouch);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        animator.SetBool("Jumping", !controller.m_Grounded);

        if (Input.GetButtonDown("Jump2"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch2"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch2"))
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
