using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 120f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Rotate();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float v = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * v * moveSpeed;

        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
    }

    void Rotate()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * h * rotateSpeed * Time.deltaTime);
    }
}