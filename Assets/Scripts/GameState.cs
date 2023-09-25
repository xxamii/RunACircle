using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private bool _isGameOn = false;
    public bool IsGameOn => _isGameOn;
    private bool _firstRun = true;

    [SerializeField] private WallSpawner _wallSpawner;
    [SerializeField] private SpeedIncreaser _speedIncreaser;

    private HUD _hud;

    private static GameState _instance;
    public static GameState Instance => _instance;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _hud = HUD.Instance;
    }

    private void Update()
    {
        if (!_isGameOn && Input.GetButtonDown("Jump"))
        {
            if (_firstRun)
                StartGame();
            else
                SceneLoader.ReloadScene();
        }
            
    }

    private void StartGame()
    {
        _wallSpawner.StartSpawn();
        _speedIncreaser.StartIncrease();
        _isGameOn = true;
        _firstRun = false;
        _hud.CloseMainMenu();
    }

    public void StopGame()
    {
        _wallSpawner.StopSpawn();
        _speedIncreaser.StopIncrease();
        _isGameOn = false;
        _hud.ShowLoseMenu();
    }
}
