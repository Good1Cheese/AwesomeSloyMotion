using UnityEngine;

/// <summary>
/// SO, содержащий данные о об оружии
/// </summary>
[CreateAssetMenu(fileName = "New Gun", menuName = "ScriptableObjects/Gun")]
public class Gun_SO : ScriptableObject
{
    /// <summary>
    /// Задержка после выстрела
    /// </summary>
    public float delayAfterShot;

    /// <summary>
    /// Дальность полета пули
    /// </summary>
    public float maxShootingDistance;

    /// <summary>
    /// Размер области спавна пуль
    /// </summary>
    public float spawnRadious;

    /// <summary>
    /// SO пули
    /// </summary>
    public Bullet_SO bullet_SO;
}
