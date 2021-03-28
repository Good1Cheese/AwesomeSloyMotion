using UnityEngine;

[RequireComponent(typeof(Capsule))]
public class CapsuleMovement : MonoBehaviour
{
    Capsule_SO m_capsule;

    void Awake()
    {
        m_capsule = Capsule.Capsule_SO;
    }

    void Update()
    {
        Move();
    }
    void Move()
    {
        transform.Translate(-transform.forward * m_capsule.speedMultiplier * Time.deltaTime);
    }
}