using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _enemiesKilledText;
    [SerializeField] private TextMeshProUGUI _survivalTimeText;
    [SerializeField] private Slider _healthDisplay;

    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if (_gameManager == null)
        {
            Debug.LogError("GameManager is null.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEnemiesKilledText();
        UpdateSurvivalTimeText();
    }

    public void UpdateEnemiesKilledText()
    {
        _enemiesKilledText.SetText("Enemies killed: " + _gameManager.KilledEnemies.ToString());
    }

    public void UpdateSurvivalTimeText()
    {
        _survivalTimeText.SetText("Survival Time: " + _gameManager.SurvivalTime.ToString());
    }
}
