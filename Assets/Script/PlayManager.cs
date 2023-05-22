using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayManager : MonoBehaviour
{
    [SerializeField] GameObject FinishedCanvas;
    [SerializeField] TMP_Text finishedText;
    [SerializeField] CustomEvent gameOverEvent;
    [SerializeField] CustomEvent playerWinEvent;
    [SerializeField] private int coin;
    public UnityEvent<int> OnScoreUpdate;

    // int coin = 10; //TODO

    private void OnEnable()
    {
        gameOverEvent.OnInvoked.AddListener(GameOver);
        playerWinEvent.OnInvoked.AddListener(PlayerWin);
    }

    private void OnDisable()
    {
        gameOverEvent.OnInvoked.RemoveListener(GameOver);
        playerWinEvent.OnInvoked.RemoveListener(PlayerWin);
    }

    public void GameOver()
    {
        GameManagerSettings gameManager = FindObjectOfType<GameManagerSettings>();
        gameManager.GameActive = false;
        finishedText.text = "You Failed";
        FinishedCanvas.SetActive(true);
    }

    public void PlayerWin()
    {
        GameManagerSettings gameManager = FindObjectOfType<GameManagerSettings>();
        gameManager.GameActive = false;
        finishedText.text = "You Win!!\nScore: " + GetScore();
        FinishedCanvas.SetActive(true);
    }

    public void AddCoin(int CoinData)
    {
        this.coin += CoinData;
        OnScoreUpdate.Invoke(GetScore());
    }

    private int GetScore()
    {
        // return coin * 10;
        return coin;
    }
}
