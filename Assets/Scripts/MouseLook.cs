using UnityEngine;

/// <summary>
/// Класс, отчающий за вращение камеры и игрока с помощью мышки
/// </summary>
public class MouseLook : MonoBehaviour
{
    GameObject Player;
    [SerializeField] float m_mouseSensitivity;
    float m_yRotation = 0;

    void Start()
    {
        GameController.Instance.PlayerCamera = gameObject;
        Cursor.lockState = CursorLockMode.Locked;
        Player = GameController.Instance.Player;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * m_mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * m_mouseSensitivity * Time.deltaTime; 

        RotateCamera(mouseY);
        RotatePlayer(mouseX);
    }

    void RotatePlayer(float mouseX) => Player.transform.Rotate(Vector3.up * mouseX);

    void RotateCamera(float mouseY)
    {
        m_yRotation -= mouseY;
        m_yRotation = Mathf.Clamp(m_yRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(m_yRotation, 0, 0);
    }
}
