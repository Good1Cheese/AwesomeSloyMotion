using UnityEngine;

/// <summary>
/// Responsible for player movement
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Player speed multiplier")]
    [SerializeField] float m_speedMultiplier;

    CharacterController m_characterController;

    void Start()
    {
        m_characterController = GetComponent<CharacterController>();
        MainLinks.Instance.Player = gameObject;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vectical = Input.GetAxis("Vertical");
        
        Vector3 move = (transform.right * horizontal) + (transform.forward * vectical);
        m_characterController.Move(move * Time.unscaledDeltaTime * m_speedMultiplier);
    }
}

