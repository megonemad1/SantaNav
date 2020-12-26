using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    [SerializeField]
    KeyboardCharProvider[] keys;

    public void upper()
    {
        foreach (var k in keys) k.Upper();
    }
    public void lower()
    {
        foreach (var k in keys) k.Lower();

    }
}
