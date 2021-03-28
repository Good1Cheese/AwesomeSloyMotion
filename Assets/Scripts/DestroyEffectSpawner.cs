using UnityEngine;

public class DestroyEffectSpawner : MonoBehaviour
{
    GameObject destroyEffect;

    void Start()
    {
        destroyEffect = Capsule.Capsule_SO.destroyEffect;
        MainLinks.Instance.OnCapsuleDestruction += SpawnExplosion;
    }

    void SpawnExplosion()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
    }
}

