using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed;
    Rigidbody2D rgb2d;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        rgb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rgb2d.velocity = new Vector2(-speed,rgb2d.velocity.y);
        }else if (Input.GetKey(KeyCode.D))
        {
            rgb2d.velocity = new Vector2(speed, rgb2d.velocity.y);
        }
        else
        {
            rgb2d.velocity = new Vector2(0, rgb2d.velocity.y);
        }
    }
}
