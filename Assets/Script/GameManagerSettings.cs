using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerSettings : MonoBehaviour
{
    [SerializeField] TMP_Text textTimer;
    [SerializeField] float Waktu = 100;
    [SerializeField] GameObject gameOver;
    public GravityController controller;
    public bool GameActive = false;
    private bool finishedd = false;
    float s;

    void SetText()
    {
        int Minute = Mathf.FloorToInt(Waktu / 60);
        int Seconds = Mathf.FloorToInt(Waktu % 60);
        textTimer.text = Minute.ToString("00") + ":" + Seconds.ToString("00");
    }

    // Update is called once per frame
    private void Update()
    {
        if(finishedd)
            return;

        if(GameActive)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }

        if(GameActive && Waktu <= 0)
        {
            controller.SetActive(false);
            GameActive = false;
            gameOver.SetActive(true);
        }

        SetText();
    }

    public void Finish()
    {
        controller.SetActive(false);
        finishedd = true;
        textTimer.color = Color.yellow;
    }
}
