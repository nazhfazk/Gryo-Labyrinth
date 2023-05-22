using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Coin Data", menuName = "Custom Asset/Coin Data")]
public class CoinData : ScriptableObject
{
    public int value;
    public Material material;

    internal static string Instantiate()
    {
        throw new NotImplementedException();
    }
}
