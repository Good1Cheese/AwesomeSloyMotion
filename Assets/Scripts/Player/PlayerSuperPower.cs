using UnityEngine;

[RequireComponent(typeof(ISuperAbilable))]
public class PlayerSuperPower : MonoBehaviour
{
    bool m_isPowerActivated;
    ISuperAbilable m_superAbilable;

    void Start()
    {
        m_superAbilable = GetComponent<ISuperAbilable>();
    }

    void Update()
    {
        if (Input.GetButtonDown("SuperPowerButton"))
        {
            m_isPowerActivated = !m_isPowerActivated;
        }

        if (m_isPowerActivated)
        {
            m_superAbilable.ActivatePower();
        }
        else
        {
            m_superAbilable.DeactivatePower();
        }
    }
}
