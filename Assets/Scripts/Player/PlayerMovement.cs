using UnityEngine;

/// <summary>
/// Отвечает за передвижения игрока
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Множитель скорости")] [SerializeField] float m_speed;
    CharacterController m_characterController;

    void Start()
    {
        MainLinks.Instance.Player = gameObject;
        m_characterController = GetComponent<CharacterController>();
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
        m_characterController.Move(move * Time.deltaTime * m_speed);
    }
}

