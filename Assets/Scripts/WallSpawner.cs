using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _wallsPrefabs;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _circleCenter;

    private Transform _transform;

    [SerializeField] private float _spawnTime;

    private bool _isSpawning = false;

    private void Start()
    {
        _transform = transform;
    }

    private void Spawn()
    {
        GameObject toSpawn = _wallsPrefabs[Random.Range(0, _wallsPrefabs.Length)];
        GameObject wall = Instantiate(toSpawn, _spawnPoint.position, Quaternion.identity);
        wall.transform.parent = _transform;
        wall.transform.up = (_spawnPoint.position - _circleCenter.position).normalized;
    }

    public void StartSpawn()
    {
        _isSpawning = true;
        StartCoroutine(SpawnRoutine());
    }

    public void StopSpawn()
    {
        _isSpawning = false;
    }

    private IEnumerator SpawnRoutine()
    {
        while(_isSpawning)
        {
            Spawn();
            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
