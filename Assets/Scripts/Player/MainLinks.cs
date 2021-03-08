using System;
using UnityEngine;

/// <summary>
/// �������� �������� ������ ����
/// </summary>
public class MainLinks : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// ��������� ������
    /// </summary>
    public static MainLinks Instance;

    [Tooltip("���� ���������� � ����")] [SerializeField] float gameGravity;

    /// <summary>
    /// ���������� ����
    /// </summary>
    public float GameGravity { get => gameGravity; }

    /// <summary>
    /// ������ ������ �� �����
    /// </summary>
    public GameObject PlayerCamera { get; set; }

    /// <summary>
    /// ����� �� �����
    /// </summary>
    public GameObject Player { get; set; }

    /// <summary>
    /// CharacterController ������
    /// </summary>
    public CharacterController PlayerCharacterController { get; set; }

    /// <summary>
    /// �������, ���������� ��� �������� ������
    /// </summary>
    public Action OnPlayerShoots { get; set; }

    /// <summary>
    /// ������ �� ������ ������
    /// </summary>
    public Gun_SO PlayerGun_SO { get; set; } 
    #endregion

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("dadada");
            return;
        }
    }

}
