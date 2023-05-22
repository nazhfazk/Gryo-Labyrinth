using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Custom Event", menuName = "Custom Asset/Event")]
public class CustomEvent : ScriptableObject
{
    public UnityEvent OnInvoked = new UnityEvent();
}
