using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int KilledEnemies { get; private set; }
    public int SurvivalTime { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        SurvivalTime = (int)Time.time;
    }

    public void KillAnEnemy()
    {
        KilledEnemies++;
    }

    private void StartGame()
    {
        KilledEnemies = 0;
        SurvivalTime = 0;
    } 
}
