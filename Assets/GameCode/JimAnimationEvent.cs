using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JimAnimationEvent : MonoBehaviour
{
    private JimController jimController;

    private void Awake()
    {
        jimController = GetComponentInParent<JimController>();
    }

    private void JumpStop()
    {
        if (jimController != null)
        {
            jimController.Jump();
        }
    }
}
