using UnityEngine;

public class TimeSlower : MonoBehaviour, ISuperAbilable
{
    [SerializeField] float m_slowdownFactor;
    [SerializeField] float m_slowdownLenght;

    public void ActivatePower()
    {
        Time.timeScale = m_slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }

    public void DeactivatePower()
    {
        if (Time.timeScale != 1f)
        {
            Time.timeScale += (1f / m_slowdownLenght) * Time.unscaledDeltaTime;
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0, 1f);
        }
    }
}
