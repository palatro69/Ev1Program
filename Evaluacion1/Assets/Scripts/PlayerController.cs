using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 7f; 
    private Rigidbody2D rb;
    private float moveX;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y);
    }
}


