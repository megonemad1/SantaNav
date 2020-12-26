using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    [SerializeField]
    public string content;
    [SerializeField]
    UnityEngine.Events.UnityEvent<string> onChange;
    [SerializeField]
    UnityEngine.Events.UnityEvent<string> onSubmit;
    public void Submit() => onSubmit.Invoke(content);
    [SerializeField]
    UnityEngine.Events.UnityEvent onExit;
    public void Exit() => onExit.Invoke();
    public void SetText(string s)
    {
        if (s != this.content)
        {
            this.content =  s;
            onChange.Invoke(content);
        }
    }
    public void InsertChar(string s)
    {
        Debug.Log("insert " + s + "into '" + content + "'");
        this.content = this.content + s;
        onChange.Invoke(content);
    }
    public void backspace()
    {
        if (content.Length > 0) content = content.Remove(content.Length - 1);
        onChange.Invoke(content);
    }

}
