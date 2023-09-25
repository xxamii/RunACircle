using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRandomizer : MonoBehaviour
{
    [SerializeField] private Color32[] _colors;

    private SpriteRenderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();

        _renderer.color = _colors[Random.Range(0, _colors.Length)];
    }
}
