using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform _transform;
    private FauxGravityBody _gravityBody;
    private PlayerCollision _collision;
    private Rigidbody2D _rigidBody;
    private PlayerAudio _audio;

    [SerializeField] private float _jumpForce;

    private bool _jumpInput;

    private void Start()
    {
        _collision = GetComponent<PlayerCollision>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _gravityBody = GetComponent<FauxGravityBody>();
        _audio = GetComponent<PlayerAudio>();
        _transform = transform;
    }

    private void FixedUpdate()
    {
        TryJump();

        _transform.localPosition = new Vector2(0, _transform.localPosition.y);
    }

    public void SwitchSide()
    {
        _transform.localPosition = new Vector2(_transform.localPosition.x, -_transform.localPosition.y);
        _gravityBody.SwitchGravity();
        _transform.Rotate(180, 0, 0);
        _audio.PlaySwitch();
    }

    public void InputJump()
    {
        _jumpInput = true;
    }

    public void TryJump()
    {
        if (_jumpInput && _collision.IsGrounded())
        {
            _rigidBody.velocity = _transform.up * _jumpForce;
            _audio.PlayJump();
        }

        _jumpInput = false;
    }
}
