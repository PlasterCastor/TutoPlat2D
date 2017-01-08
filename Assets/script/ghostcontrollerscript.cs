using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostcontrollerscript : MonoBehaviour
{

    public float maxSpeed = 10f;
    bool facingLeft = false;

    Animator anim;
    Rigidbody2D body;
    SpriteRenderer renderer;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
    
        
        anim.SetFloat("Speed", Mathf.Abs(move));
        body.velocity = new Vector2(move * maxSpeed, body.velocity.y);
        Vector2 example = GetComponent<Rigidbody2D>().velocity;
        example = new Vector2(maxSpeed * move, example.y);


        if (move > 0 && facingLeft)
            Flip();
        else if(move < 0 && !facingLeft)
            Flip();
     }
    
    void Flip()
    {
        facingLeft = !facingLeft;
        renderer.flipX = facingLeft;        
    }
} 