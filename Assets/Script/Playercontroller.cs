using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Component")]
    Rigidbody2D rb;
    Animator anim;

    [Header("Stat")]
    [SerializeField]
    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for player input here if needed
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    { 
        if(Input.GetAxis("Horizontal") > 0.1 || Input.GetAxis("Horizontal") > 0.1 || Input.GetAxis("Vertical") > 0.1 || Input.GetAxis("Vertical") < -0.1) 
        {
            anim.SetFloat("lastInputX",Input.GetAxis("Horizontal"));
            anim.SetFloat("lastInputY",Input.GetAxis("Vertical"));
        }


        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(x, y) * moveSpeed * Time.fixedDeltaTime;

        if(x !=0 || y !=0)
        {
            anim.SetFloat("inputX", x);
            anim.SetFloat("inputY", y);
        }    
    }
}

