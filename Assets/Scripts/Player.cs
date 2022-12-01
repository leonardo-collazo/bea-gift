using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Variables
    [SerializeField] private float jumpForce;
    [SerializeField] private int maxAmountJumps;
    [SerializeField] private float checkRadius;
    [SerializeField] private bool isGrounded;

    [SerializeField] LayerMask whatIsGround;
    [SerializeField] Animator animator;

    private int amountJumps;
    private Rigidbody2D rb;

    public bool IsGrounded => isGrounded;
    #endregion

    private void Start()
    {
        amountJumps = maxAmountJumps;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && amountJumps > 0)
        {
            Jump();
            isGrounded = false;
            amountJumps--;
        }
    }

    // Applies a force to the player in the direction of the y-axis
    void Jump()
    {
        animator.SetTrigger("jump");
        FindObjectOfType<AudioManager>().Play("Jump");
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0, jumpForce));
    }

    void ResetJumps()
    {
        amountJumps = maxAmountJumps;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            FindObjectOfType<AudioManager>().Play("Land");
            isGrounded = true;
            ResetJumps();
        }
    }
}
