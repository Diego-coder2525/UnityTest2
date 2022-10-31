using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControllerDiego : MonoBehaviour
{
    float speed;
    Rigidbody2D rgb2d;
    public float JumpForce;
    Animator animator;
    public bool Grounded;
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
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = false;
        }
        else
        {
            Grounded = true;
        }
        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }

    }
    private void Jump()
    {
        rgb2d.AddForce(Vector2.up * JumpForce);
    }
}
