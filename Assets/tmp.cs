using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tmp : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sr.bounds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
