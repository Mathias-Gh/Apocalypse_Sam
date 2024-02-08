using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroleur : MonoBehaviour
{
   public Rigidbody2D rb;
   public float Vitesse;
   Vector2 mouvement;
   public Animator animator;

    // Update is called once per frame
    void Update()
    {
      mouvement.x = Input.GetAxisRaw("Horizontal");
      mouvement.y = Input.GetAxisRaw("Vertical");

      animator.SetFloat("Horizontal", mouvement.x);
      animator.SetFloat("Vertical", mouvement.y);
      animator.SetFloat("Speed", mouvement.magnitude);

      rb.MovePosition(rb.position + mouvement * Vitesse * Time.deltaTime);
    }
}
 