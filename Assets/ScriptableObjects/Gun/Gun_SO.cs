using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "ScriptableObjects/Gun")]
public class Gun_SO : ScriptableObject
{
    /// <summary>
    /// �������� ����� ��������
    /// </summary>
    public float delayAfterShot;

    public GameObject bulletPrefab;
}
