using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "ScriptableObjects/Gun")]
public class Gun_SO : ScriptableObject
{
    /// <summary>
    /// Задержка после выстрела
    /// </summary>
    public float delayAfterShot;

    public GameObject bulletPrefab;
}
