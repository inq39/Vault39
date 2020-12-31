using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject[] _spawnPoints;
    [SerializeField] private int _spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 3, _spawnTime);
    }

    void SpawnEnemies()
    {
        Instantiate(_enemyPrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform.position, Quaternion.identity);
    }
}
