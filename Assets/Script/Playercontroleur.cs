using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroleur : MonoBehaviour
{

    [Header("Component")]
    public Rigidbody2D rb;
    public float Vitesse;

    Vector2 mouvement;

    [Header("Stat")]
    [SerializeField]

    [Header("Attack")]
    private float attackTime;
    [SerializeField] float timeBetweenAttack;
    public CapsuleCollider2D playerCollider;


    public Animator animator;

    public static Playercontroleur instance;


    public void Awake()
    {
        if (instance != null) 
        {
            Debug.LogWarning("Il y a plus d'une instance de Playercontroleur dans la sc�ne");
            return;
        }
    
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        mouvement.x = Input.GetAxisRaw("Horizontal");
        mouvement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", mouvement.x);
        animator.SetFloat("Vertical", mouvement.y);
        animator.SetFloat("Speed", mouvement.magnitude);

        rb.MovePosition(rb.position + mouvement * Vitesse * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
        }
    }
}