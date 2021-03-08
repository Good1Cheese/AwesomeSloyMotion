using System.Collections;
using UnityEngine;

/// <summary>
/// Отвечает за стрельбу игрока
/// </summary>
[RequireComponent(typeof(ShootAnimaitonProvider), typeof(ShootSoundProvider))]
public class PlayerShooting : MonoBehaviour
{
    bool m_isShootingActivated = false;
    bool m_isDelayGoing = false;
    [SerializeField] Gun_SO m_gun_SO;
    GameObject m_bulletPrefab;

    void Start()
    {
        MainLinks.Instance.PlayerGun_SO = m_gun_SO;
        m_bulletPrefab = m_gun_SO.bullet_SO.bulletPrefab;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            m_isShootingActivated = !m_isShootingActivated;
        }

        if (m_isShootingActivated && !m_isDelayGoing)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        m_isDelayGoing = true;

        Vector3 spawnPosition = Random.insideUnitSphere * m_gun_SO.spawnRadious;
        Instantiate(m_bulletPrefab, transform.position + spawnPosition, m_bulletPrefab.transform.rotation);
        MainLinks.Instance.OnPlayerShoots.Invoke();

        yield return new WaitForSeconds(m_gun_SO.delayAfterShot);
        m_isDelayGoing = false;
    }
}
