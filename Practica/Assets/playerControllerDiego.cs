using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControllerDiego : MonoBehaviour
{
    [SerializeField]LayerMask layerMask;
    float JumpForce;
    Rigidbody2D rgb2d;
    BoxCollider2D box2d;
    public GameObject plataforma;
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        box2d = GetComponent<BoxCollider2D>();
        JumpForce = 15f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rgb2d.velocity = Vector2.up * JumpForce;
        }

    }
    bool isGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(box2d.bounds.center, box2d.bounds.size, 0f, Vector2.down,.1f,layerMask);
        return raycastHit2d.collider != null;
    }
}
