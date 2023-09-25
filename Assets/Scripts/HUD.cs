using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class HUD : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    private Animator _animator;

    private static HUD _instance;
    public static HUD Instance => _instance;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void UpdateScore(float amount)
    {
        _scoreText.text = amount.ToString();
    }

    public void CloseMainMenu()
    {
        _animator.SetTrigger("CloseMain");
    }

    public void ShowLoseMenu()
    {
        _animator.SetTrigger("ShowLose");
    }
}
