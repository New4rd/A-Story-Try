using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] public float speedMovement;
    [SerializeField] public bool lookLeft;

    private Rigidbody2D rb;
    private Animator characterAnimator;
    private SpriteRenderer chRenderer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        characterAnimator = GetComponent<Animator>();
        chRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            lookLeft = false;
            chRenderer.flipX = lookLeft;
            characterAnimator.SetTrigger("Start Walking");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speedMovement, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            lookLeft = true;
            chRenderer.flipX = lookLeft;
            characterAnimator.SetTrigger("Start Walking");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speedMovement, rb.velocity.y);
        }

        if (Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.RightArrow))
        {
            characterAnimator.SetTrigger("Stop Walking");
        }
    }
}
