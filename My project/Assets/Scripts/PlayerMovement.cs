using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnMovement (InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x !=0 || movement.y !=0) // Para que el sprite sea el de la ultima tecla oprimida
        {
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(movement * speed);
    }
}
