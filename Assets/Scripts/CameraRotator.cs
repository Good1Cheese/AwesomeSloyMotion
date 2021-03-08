using UnityEngine;

/// <summary>
/// Класс, отвечающий за вращение камеры
/// </summary>
public class CameraRotator : MonoBehaviour
{
    [Tooltip("Вертикальная чувствительность игрока")] [SerializeField] float m_verticalMouseSensivity;
    float m_yRotation = 0;

    void Start()
    {
        MainLinks.Instance.PlayerCamera = gameObject;    
    }

    void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        float mouseY = Input.GetAxis("Mouse Y") * m_verticalMouseSensivity * Time.deltaTime; 

        m_yRotation -= mouseY;
        m_yRotation = Mathf.Clamp(m_yRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(m_yRotation, 0, 0);
    }

}
