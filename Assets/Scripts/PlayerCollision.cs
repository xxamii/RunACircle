using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private Transform _transform;
    [SerializeField] private float _groundCheckDistance = 0.4f;

    [SerializeField] private GameObject _deathParticles;

    private PlayerAudio _audio;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _audio = GetComponent<PlayerAudio>();
    }

    public bool IsGrounded()
    {
        RaycastHit2D groundRay = Physics2D.Raycast(_transform.position, -_transform.up, _groundCheckDistance);
        return groundRay;
    }

    public void DestroySelf()
    {
        Instantiate(_deathParticles, _transform.position, Quaternion.identity);
        _audio.PlayBump();
        Destroy(gameObject);
    }
}
