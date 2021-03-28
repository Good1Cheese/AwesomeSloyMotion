using UnityEngine;

/// <summary>
/// Responsoble for player physics
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class PlayerPhysics : MonoBehaviour
{
    [SerializeField] float m_jumpHeight;
    [SerializeField] float m_initialFallingForce;
    CharacterController m_characterController;
    Vector3 m_velocity;
    float m_gravity;

    void Start()
    {
        m_characterController = GetComponent<CharacterController>();
        m_gravity = MainLinks.Instance.GravityForce;
    }

    void Update()
    {
        Jump();
        ÑreateGravity();

        if (m_characterController.isGrounded && m_velocity.y < 0)
        {
            m_velocity.y = m_initialFallingForce;
        }

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && m_velocity.y == m_initialFallingForce)
        {
            m_velocity.y = Mathf.Sqrt(m_jumpHeight * -2 * m_gravity);
        }

    }

    void ÑreateGravity()
    {
        m_velocity.y += m_gravity * Time.unscaledDeltaTime;
        m_characterController.Move(m_velocity * Time.unscaledDeltaTime);
    }
}
