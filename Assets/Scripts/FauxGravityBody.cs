using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    private float _gravity = -9.81f;

    [SerializeField] private Transform _attractor;
    private Transform _transform;
    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _transform = transform;
    }

    private void FixedUpdate()
    {
        AttractSelf();
    }
         
    private void AttractSelf()
    {
        Vector2 gravityUp = (_transform.position - _attractor.position).normalized;
        _rigidBody.AddForce(gravityUp * _gravity);
    }

    public void SwitchGravity()
    {
        _gravity *= -1;
    }
}
