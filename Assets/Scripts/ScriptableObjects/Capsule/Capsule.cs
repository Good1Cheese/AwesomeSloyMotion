using UnityEngine;
public class Capsule : MonoBehaviour
{
    [SerializeField] Capsule_SO m_capsule_SO;
    public static Capsule_SO Capsule_SO { get; private set; }

    void Awake()
    {
        Capsule_SO = m_capsule_SO;    
    }
}