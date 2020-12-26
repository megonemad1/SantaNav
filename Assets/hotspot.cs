using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class hotspot : MonoBehaviour
{
    [SerializeField]
    UnityEvent onMouseUp;
    [SerializeField]
    UnityEvent onMouseDown;
    [SerializeField]
    UnityEvent onMouseEnter;
    [SerializeField]
    UnityEvent onMouseExit;

    private void OnMouseUpAsButton()
    {
        onMouseUp.Invoke();
    }

    private void OnMouseEnter()
    {
        onMouseEnter.Invoke();
    }
    private void OnMouseExit()
    {
        onMouseExit.Invoke();
    }
    private void OnMouseDown()
    {
        onMouseDown.Invoke();        
    }
}
