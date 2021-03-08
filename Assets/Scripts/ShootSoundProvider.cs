using UnityEngine;

/// <summary>
/// Отвечает за звуки, производимые при выстреле
/// </summary>
[RequireComponent(typeof(AudioSource))]
public class ShootSoundProvider : MonoBehaviour, IProvider
{
    AudioSource m_audioSource;

    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
        if(m_audioSource.clip == null)
        {
            Debug.LogError("You have no sound to play !");
        }

        MainLinks.Instance.OnPlayerShoots += Provide;
    }

    public void Provide()
    {
        m_audioSource.Play();
    }

    void OnDisable()
    {
        MainLinks.Instance.OnPlayerShoots -= Provide;
    }
}