using UnityEngine;
/// <summary>
/// SO, содержащий данные о об пуле
/// </summary>
[CreateAssetMenu(fileName = "New Bullet", menuName = "ScriptableObjects/Bullet")]
public class Bullet_SO : ScriptableObject
{
    /// <summary>
    /// Префаб пули
    /// </summary>
    public GameObject bulletPrefab;

    /// <summary>
    /// Задержка уничтожения
    /// </summary>
    public float destroyDelay;
}