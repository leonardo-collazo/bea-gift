using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private int maxAmountJumps;
    [SerializeField] private float checkRadius;
    [SerializeField] private bool isGrounded;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask whatIsGround;

    private int amountJumps;
    private Rigidbody2D rb;

    public bool IsGrounded => isGrounded;

    private void Start()
    {
        amountJumps = maxAmountJumps;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        if (Input.GetMouseButtonDown(0) && amountJumps > 0)
        {
            amountJumps--;
            Jump();
        }
        else if (Input.GetMouseButtonDown(0) && amountJumps == 0 && isGrounded)
        {
            Jump();
        }

        if (isGrounded)
        {
            amountJumps = maxAmountJumps;
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0, jumpForce));
    }
}
