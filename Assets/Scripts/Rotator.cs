using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Transform _circleCenter;
    private Transform _transform;

    [SerializeField] private float _rotationSpeed;

    // SHOULD NOT DO THIS, MAYBE CHANGE LATER
    [SerializeField] private Transform _wallShredder;
    [SerializeField] private Transform _wallSpawnPoint;

    private void Start()
    {
        _transform = transform;

        if (Random.Range(-1f, 1f) >= 0)
        {
            _rotationSpeed *= -1;

            // SHOULD NOT DO THIS, MAYBE CHANGE LATER
            _wallSpawnPoint.localPosition = new Vector2(-_wallSpawnPoint.localPosition.x, _wallSpawnPoint.localPosition.y);
            _wallShredder.localPosition = new Vector2(-_wallShredder.localPosition.x, _wallShredder.localPosition.y);
        }
    }

    private void FixedUpdate()
    {
        _transform.RotateAround(_circleCenter.position, Vector3.forward, _rotationSpeed);
    }
}
