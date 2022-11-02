using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rgb2d;
    public float speed;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        rgb2d.velocity = direction * speed;
    }
    public void setDirection(Vector2 dir)
    {
        direction = dir;
    }
}
