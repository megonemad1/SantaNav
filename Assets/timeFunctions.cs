using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeFunctions : MonoBehaviour
{

    public void pause()
    {
        Time.timeScale = 0;
    }
    public void unpause()
    {
        Time.timeScale = 1;
    }
}
