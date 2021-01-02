using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private GameObject _player;
    private GameManager _gameManager;
    [SerializeField] private int _enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        if (_player == null)
        {
            Debug.LogError("Player is null.");
        }

        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if (_gameManager == null)
        {
            Debug.LogError("GameManager is null.");
        }


    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<NavMeshAgent>().destination = _player.transform.position;
        CheckForEnemyHealth();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            _enemyHealth--;
            Destroy(collision.gameObject);
        }
    }

    private void CheckForEnemyHealth()
    {
        if (_enemyHealth <= 0)
        {
            _gameManager.KillAnEnemy();
            Destroy(this.gameObject);
        }
    }
}
