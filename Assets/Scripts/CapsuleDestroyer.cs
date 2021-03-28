using System.Collections;
using System;
using UnityEngine;

public class CapsuleDestroyer : MonoBehaviour
{
    Capsule_SO m_capsule_SO;
    MeshRenderer meshRenderer;
    bool m_isColorChanging;
    float m_flyLimit; 

    void Start()
    {
        m_capsule_SO = Capsule.Capsule_SO;
        meshRenderer = GetComponent<MeshRenderer>();
        m_flyLimit = transform.position.z + m_capsule_SO.flyDistance;
    }

    void Update()
    {
        if (transform.position.z >= m_flyLimit && !m_isColorChanging)
        {
            StartCoroutine(Change—olor());

            Destroy(gameObject, m_capsule_SO.destroyDelay);
            //TODO: Code below schould call only one time
            MainLinks.Instance.OnCapsuleDestruction.Invoke();
        }

    }

    IEnumerator Change—olor()
    {
        m_isColorChanging = true;
        float colorChangeTime = m_capsule_SO.destroyDelay / 6;
        meshRenderer.material.SetColor("_Color", m_capsule_SO.destroyColor);
        yield return new WaitForSeconds(colorChangeTime);

        meshRenderer.material.SetColor("_Color", m_capsule_SO.secondaryDestroyColor);
        yield return new WaitForSeconds(colorChangeTime);
        m_isColorChanging = false;
    }

}
