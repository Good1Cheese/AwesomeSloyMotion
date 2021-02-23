using UnityEngine;

/// <summary>
/// Отвечает за физику игрока
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class PlayerPhysicsController : MonoBehaviour
{
    [SerializeField] float m_jumpHeight;
    [SerializeField] float m_initialFallingForce;
    CharacterController m_characterController;
    Vector3 velocity;
    float gravity;

    void Start()
    {
        gravity = GameController.Instance.GameGravity;
        m_characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Jump();
        Gravity();
        
        if(m_characterController.isGrounded && velocity.y < 0)
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

    void Gravity()
    {
        velocity.y += gravity * Time.deltaTime;
        m_characterController.Move(velocity * Time.deltaTime);
    }
}
