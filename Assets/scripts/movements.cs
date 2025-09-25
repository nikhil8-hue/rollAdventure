using UnityEngine;

public class movements : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    public Transform groundCheck;
    public float checkRadius = 0.1f;
    public LayerMask whatIsGround;
    public bool isGrounded;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movement
        moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y); 

        // Ground check
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        // Jump
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); 
        }
    }
}
