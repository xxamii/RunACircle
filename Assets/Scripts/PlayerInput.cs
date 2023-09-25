using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _movement;

    private void Start()
    {
        _movement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        SwitchSideInput();
        JumpInput();
    }

    private void SwitchSideInput()
    {
        if (Input.GetKeyDown(KeyCode.C))
            _movement.SwitchSide();
    }

    private void JumpInput()
    {
        if (Input.GetButtonDown("Jump"))
            _movement.InputJump();
    }
}
