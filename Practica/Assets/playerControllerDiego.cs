using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControllerBruno : MonoBehaviour
{
    public GameObject bulletPf;
    float speed;
    Rigidbody2D rgb2d;
    Animator animator;

    float lastShoot;

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
            if (Input.GetKey(KeyCode.J))
            {
                
                animator.Play("PlayerShootRun");
            }
            else
            {
                animator.Play("PlayerRun");
            }
            rgb2d.velocity = new Vector2(-speed, rgb2d.velocity.y);
            transform.localScale = new Vector2(-1, 1);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.J))
            {
               
                animator.Play("PlayerShootRun");
            }
            else
            {
                animator.Play("PlayerRun");
            }
            rgb2d.velocity = new Vector2(speed, rgb2d.velocity.y);
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            if (Input.GetKey(KeyCode.J))
            {
    
                animator.Play("PlayerShootIdle");
            }
            else
            {
                animator.Play("PlayerIdle");
            }
            rgb2d.velocity = new Vector2(0, rgb2d.velocity.y);


        }

        if(Input.GetKey(KeyCode.J) && Time.time > lastShoot + 0.25f)
        {
            Shoot();
            lastShoot = Time.time;
        }


    }
    void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1f) direction = Vector2.right;
        else direction = Vector2.left;
        GameObject bullet = Instantiate(bulletPf, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<bullet>().setDirection(direction);
    }
}
