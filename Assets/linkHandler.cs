using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class linkHandler : MonoBehaviour
{
    [SerializeField]
    bool hide_if_empty = true;
    [SerializeField]
    string _link;
    public string link
    {
        get => _link; set
        {
            _link = value;
            gameObject.SetActive(_link != "" && hide_if_empty);
        }
    }
    public void go()
    {

#if !UNITY_EDITOR
		openWindow(link);
#endif
#if UNITY_EDITOR
        Debug.Log("goto: " + link);
#endif
    }
    [DllImport("__Internal")]
    private static extern void openWindow(string url);
}
