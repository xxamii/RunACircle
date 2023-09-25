using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float _currentScore = 0f;

    private HUD _hud;

    private GameState _gameState;

    private void Start()
    {
        _hud = HUD.Instance;
        _gameState = GameState.Instance;
    }

    private void Update()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        if (_gameState.IsGameOn)
        {
            _currentScore += Time.deltaTime;
            _hud.UpdateScore(Mathf.RoundToInt(_currentScore));
        }
    }
}
