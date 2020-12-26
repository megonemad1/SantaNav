using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardCharProvider : MonoBehaviour
{
    [SerializeField]
    UnityEngine.Events.UnityEvent<string> onChar;
    // Start is called before the first frame update
    [SerializeField]
    TMPro.TextMeshProUGUI text;

    public void Trigger()
    {
        onChar.Invoke(gameObject.name);
    }
    public void Upper()
    {
        gameObject.name = gameObject.name.ToUpper();
        text.text = gameObject.name;
    }
    public void Lower()
    {
        gameObject.name = gameObject.name.ToLower();
        text.text = gameObject.name;
    }
    [ExecuteAlways]
    private void Awake()
    {
        text.text = gameObject.name;
    }
}
