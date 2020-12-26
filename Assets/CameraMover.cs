using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer sr;
    Camera c;
    [SerializeField]
    float magnitude = 1;
    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<Camera>();
    }

    // Update is called once per frame
    public void moveTo(Vector3 newpos)
    {
        var z = this.transform.position.z;
        var p = sr.bounds.ClosestPoint(newpos);
        this.transform.position = new Vector3(p.x, p.y, z);
    }
    public void move(Vector3 dydx)
    {
        var z = this.transform.position.z;
        var p= sr.bounds.ClosestPoint(transform.position + dydx);
        this.transform.position = new Vector3(p.x, p.y, z);
    }

    public void moveUp(float hackymchacky)
    {

        move(Vector3.up * hackymchacky * magnitude * c.orthographicSize);
    }
    public void moveRight(float hackymchacky)
    {

        move(this.transform.position.z * Vector3.forward +
            Vector3.right * hackymchacky * magnitude * c.orthographicSize);
    }
    public void zoomIn()
    {
        c.orthographicSize /= 2;
    }
    public void zoomOut()
    {
        c.orthographicSize *= 2;
    }
}