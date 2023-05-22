using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    public UnityEvent<int> OnGetCoin;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Debug.Log(other.gameObject.name);
            UnityEngine.Debug.Log("CoinEnter");
            Coin coin = other.gameObject.GetComponent<Coin>();
            OnGetCoin.Invoke(coin.Value);
            coin.Collected();
            coin.SelfDestruct();
        }
        else
        {
            Debug.Log("bukan coin " + other.gameObject.name);
        }
    }
}
