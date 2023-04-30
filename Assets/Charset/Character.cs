using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float moveSpeed;
    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * 700f);
        }
        if (Mathf.Abs(dirX) > 0 && rb.velocity.y == 0)
        {
            anim.SetBool("isRunning", true);
            anim.speed = moveSpeed;
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (rb.velocity.y == 0)
        {
            anim.SetBool("isJumping", false);
        }
        if (rb.velocity.y > 0)
        {
            anim.SetBool("isJumping", true);
        }
        if (rb.velocity.y < 0)
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isJumping", true);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    private void LateUpdate()
    {
        if(dirX > 0)
        {
            facingRight = true;
        }
        else if(dirX < 0)
        {
            facingRight = false;
        }

        if(((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
        {
            transform.localScale = localScale;
        }
    }
}
