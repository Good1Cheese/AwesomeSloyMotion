using UnityEngine;

/// <summary>
/// Класс, отчающий за вращение игрока
/// </summary>
public class PlayerRotator : MonoBehaviour
{
    [SerializeField] float m_horizontalMouseSensitivity;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        RotatePlayer();
    }

    void RotatePlayer()
    {
        float mouseX = Input.GetAxis("Mouse X") * m_horizontalMouseSensitivity * Time.deltaTime;

        gameObject.transform.Rotate(Vector3.up * mouseX);
    }
}
