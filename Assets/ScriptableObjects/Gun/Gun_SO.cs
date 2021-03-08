using UnityEngine;

/// <summary>
/// SO, ���������� ������ � �� ������
/// </summary>
[CreateAssetMenu(fileName = "New Gun", menuName = "ScriptableObjects/Gun")]
public class Gun_SO : ScriptableObject
{
    /// <summary>
    /// �������� ����� ��������
    /// </summary>
    public float delayAfterShot;

    /// <summary>
    /// ��������� ������ ����
    /// </summary>
    public float maxShootingDistance;

    /// <summary>
    /// ������ ������� ������ ����
    /// </summary>
    public float spawnRadious;

    /// <summary>
    /// SO ����
    /// </summary>
    public Bullet_SO bullet_SO;
}
