using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JimController : MonoBehaviour
{
    private Animator anim;

    public bool isJumping;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !anim.GetBool("isJumping"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        anim.SetBool("isJumping", !anim.GetBool("isJumping"));
    }

    public void EndJump()
    {
        Debug.Log("EndingJump");
        anim.SetBool("isJumping", false);
    }
}
