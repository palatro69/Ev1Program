using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce = 12f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private bool isGrounded;
    private Rigidbody2D rb;
    [Header("playersound")]
    [SerializeField] private PlayerAudio playeraudio;
    private void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        Jump();
    }
    private void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            playeraudio = GetComponent<PlayerAudio>();
            playeraudio.JumpSFX();
        }
    }

}
