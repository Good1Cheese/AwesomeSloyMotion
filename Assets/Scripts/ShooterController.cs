using System.Collections;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    bool isDelayGoing = false;
    [SerializeField] Vector3 m_spawnOffset;
    [SerializeField] Gun_SO m_gun;
    GameObject bulletPrefab;

    void Start()
    {
        bulletPrefab = m_gun.bulletPrefab;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire") && !isDelayGoing)
        {
            StartCoroutine(Shoot());
        }
    }
        
    IEnumerator Shoot()
    {
        isDelayGoing = true;
        Debug.DrawRay(transform.right, transform.forward, Color.red, 100f);
        Instantiate(bulletPrefab, transform.position, Quaternion.FromToRotation(transform.right, transform.forward), transform);
        
        yield return new WaitForSeconds(m_gun.delayAfterShot);
        isDelayGoing = false;
    }
}
