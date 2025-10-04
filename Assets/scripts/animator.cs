using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;   // Drag PlayerAnimator here
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Set speed parameter (for walk/run)
        float speed = Mathf.Abs(rb.linearVelocity.x);
        animator.SetFloat("Speed", speed);

        // Jump check
        bool isJumping = rb.linearVelocity.y > 0.1f || rb.linearVelocity.y < -0.1f;
        animator.SetBool("isJumping", isJumping);
    }
}
