using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreaser : MonoBehaviour
{
    private float _timeScale;
    [SerializeField] private float _maxTimeScale;
    private float _speedUpAmount;

    private bool _isIncreasing = false;

    private void Start()
    {
        _timeScale = Time.timeScale;
        _speedUpAmount = (_maxTimeScale - _timeScale) / 100f;
    }

    public void StartIncrease()
    {
        _isIncreasing = true;
        StartCoroutine(SpeedUpRoutine());
    }

    public void StopIncrease()
    {
        _isIncreasing = false;
    }

    private IEnumerator SpeedUpRoutine()
    {
        while(_timeScale < _maxTimeScale && _isIncreasing)
        {
            yield return new WaitForSeconds(1f);

            _timeScale += _speedUpAmount;
            Time.timeScale = _timeScale;
        }
    }
}
