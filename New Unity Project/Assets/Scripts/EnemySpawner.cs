using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyObj;
    [SerializeField] private SpawnScript[] _spawnPoints;
    [SerializeField] private float _spawnThreshold = 2;

    private float _timer;

    private void Start() 
    {
        
    }

    private void Update() 
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnThreshold)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);
        SpawnScript spawnpoint = _spawnPoints[randomIndex];
        Vector3 spawnPosition = spawnpoint.GetSpawnPosition();
        
        Instantiate(_enemyObj, spawnPosition, Quaternion.identity);
        _timer = 0;
        
        
    }


}
