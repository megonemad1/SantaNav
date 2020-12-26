using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventBehaviour : MonoBehaviour
{
    [SerializeField]
    UnityEngine.Events.UnityEvent unityEvent;
    public void Invoke() => unityEvent.Invoke();
}
