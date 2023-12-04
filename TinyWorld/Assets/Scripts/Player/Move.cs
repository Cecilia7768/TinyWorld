using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도
    public float rotationSpeed = 100f; // 회전 속도

    private Rigidbody rb;

    private Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // 키 입력 받기
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (h != 0 || v != 0)
            animator.SetBool("Move", true);        
        else
            animator.SetBool("Move", false);

        // 이동
        Vector3 moveDirection = new Vector3(h, 0f, v).normalized;
        Vector3 moveVelocity = moveDirection * moveSpeed;
        rb.velocity = new Vector3(moveVelocity.x, rb.velocity.y, moveVelocity.z);

        // 회전
        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            Quaternion newRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            transform.rotation = newRotation;
        }
    }
}
