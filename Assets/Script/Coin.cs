using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Coin : MonoBehaviour
{
    [SerializeField] Transform visual;
    [SerializeField] CoinData coinData;
    [SerializeField] BaseAnimation baseAnimation;

    public int Value { get => coinData.value; }

    private void Start()
    {
        visual.GetComponent<Renderer>().material = coinData.material;
        if(baseAnimation != null)
        {
            baseAnimation.Animate(visual);
        }
    }

    public void Collected()
    {
        GetComponent<Collider>().enabled = false;
    }

    public void SelfDestruct()
    {
        Destroy(this.gameObject);
    }
}
