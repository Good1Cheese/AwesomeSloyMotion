using System.Collections;
using UnityEngine;

public class CapsuleSpawner : MonoBehaviour
{
    [SerializeField] CapsuleSpawner_SO m_capsuleSpawner;
    bool m_isShootingActivated;
    bool m_isDelayGoing;

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

        Vector3 spawnPosition = transform.position + ( (Random.insideUnitSphere + m_capsuleSpawner.spawnSphereOffset) * m_capsuleSpawner.spawnRadiusMultiplier);

        Instantiate(m_capsuleSpawner.capsulePrefab,
            spawnPosition,
            m_capsuleSpawner.capsulePrefab.transform.rotation);

        yield return new WaitForSeconds(m_capsuleSpawner.delayAfterShot);

        m_isDelayGoing = false;
    }

}
