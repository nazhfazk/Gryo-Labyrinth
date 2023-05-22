using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class PlayCountdown : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text tmpText;
    public UnityEvent OnStart;
    public UnityEvent OnEnd;
    float timer = 3;
    bool isCounting = true;
    public GameManagerSettings gameManager;
    public GravityController gravityController;

    private void Start()
    {
        gameManager.GameActive = false;
        

        // OnStart.Invoke();
        // var sequence = DOTween.Sequence();
        // tmpText.transform.localScale = Vector3.zero;
        // tmpText.text = "3";
        // sequence.Append(tmpText.transform.DOScale(
        //     Vector3.one,
        //     1).OnComplete(() =>
        //     {
        //         tmpText.transform.localScale = Vector3.zero;
        //         tmpText.text = "2";
        //     }));

        // sequence.Append(tmpText.transform.DOScale(
        //     Vector3.one,
        //     1).OnComplete(() =>
        //     {
        //         tmpText.transform.localScale = Vector3.zero;
        //         tmpText.text = "1";
        //     }));

        // sequence.Append(tmpText.transform.DOScale(
        //     Vector3.one,
        //     1).OnComplete(() =>
        //     {
        //         tmpText.transform.localScale = Vector3.zero;
        //         tmpText.text = "GOOOO";
        //         OnEnd.Invoke();
        //     }));
    }

    private void Update()
    {
        if(!isCounting)
            return;

        timer -= Time.deltaTime;
        tmpText.text = Mathf.CeilToInt(timer).ToString();
        if(timer <= 0)
        {
            tmpText.gameObject.SetActive(false);
            gravityController.SetActive(true);
            gameManager.GameActive = true;
            isCounting = false;
        }
    }
}
