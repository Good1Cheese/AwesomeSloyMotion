using UnityEngine;

public class DestroyWithDelay : MonoBehaviour
{
    [SerializeField] float delay;

    void OnEnable()
    {
        Destroy(gameObject, delay);
    }

}
