using UnityEngine;
using UnityEngine.InputSystem;

public class moving : MonoBehaviour
{
    private float speed = 5f;
    private float curSpeed = 0;
    public float curhight = 0;
    private Rigidbody2D rb;
    public Animator animator;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    private void OnJump(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(movementX, movementY);

        rb.AddForce(movement * speed);
        var vel = rb.velocity;
        curhight = vel.y;
        curSpeed = vel.x;
        animator.SetFloat("curSpeed", curSpeed);

    }

}
