using UnityEngine;

public class BulletController : MonoBehaviour
{
    Bullet_SO bullet_SO;

    void Start()
    {
        bullet_SO = MainLinks.Instance.PlayerGun_SO.bullet_SO;
    }

    void Update()
    {
        transform.Translate(-transform.forward * Time.deltaTime);    
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, bullet_SO.destroyDelay);        
    }
}
