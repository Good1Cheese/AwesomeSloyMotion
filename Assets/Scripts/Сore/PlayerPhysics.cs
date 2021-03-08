using UnityEngine;

/// <summary>
/// �������� �� ������ ������
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class PlayerPhysics : MonoBehaviour
{
    [SerializeField] float m_jumpHeight;
    [SerializeField] float m_initialFallingForce;
    CharacterController m_characterController;
    Vector3 velocity;
    float gravity;

    void Start()
    {
        m_characterController = GetComponent<CharacterController>();
        MainLinks.Instance.PlayerCharacterController = m_characterController;
        gravity = MainLinks.Instance.GameGravity;
    }

    void Update()
    {
        Jump();
        �reateGravity();

        if (m_characterController.isGrounded && velocity.y < 0)
        {
            velocity.y = m_initialFallingForce;
        }

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && velocity.y == m_initialFallingForce)
        {
            velocity.y = Mathf.Sqrt(m_jumpHeight * -2 * gravity);
        }

    }

    void �reateGravity()
    {
        velocity.y += gravity * Time.deltaTime;
        m_characterController.Move(velocity * Time.deltaTime);
    }
}
