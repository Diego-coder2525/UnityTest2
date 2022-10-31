using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed;
    Rigidbody2D rgb2d;
    Animator animator;
  
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        rgb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rgb2d.velocity = new Vector2(-speed,rgb2d.velocity.y);
            animator.SetBool("Run", true);
            transform.localScale = new Vector2(-1, 1);
        }else if (Input.GetKey(KeyCode.D))
        {
            rgb2d.velocity = new Vector2(speed, rgb2d.velocity.y);
            animator.SetBool("Run", true);
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            rgb2d.velocity = new Vector2(0, rgb2d.velocity.y);
            animator.SetBool("Run", false);
        }
    }
}