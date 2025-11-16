using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInputVertical = Input.GetAxis("Vertical");
        float moveInputHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveInputHorizontal * speed, moveInputVertical * speed);

        // ��������� ���� ��� �������� �����������
        rb.linearVelocity = movement;
    }
}