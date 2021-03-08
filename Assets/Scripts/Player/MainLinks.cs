using System;
using UnityEngine;

/// <summary>
/// СОдержит основные ссылки игры
/// </summary>
public class MainLinks : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// ЭКземпляр класса
    /// </summary>
    public static MainLinks Instance;

    [Tooltip("Сила гравитации в игре")] [SerializeField] float gameGravity;

    /// <summary>
    /// Гравитация игры
    /// </summary>
    public float GameGravity { get => gameGravity; }

    /// <summary>
    /// Камера игрока на сцене
    /// </summary>
    public GameObject PlayerCamera { get; set; }

    /// <summary>
    /// Игрок на сцене
    /// </summary>
    public GameObject Player { get; set; }

    /// <summary>
    /// CharacterController игрока
    /// </summary>
    public CharacterController PlayerCharacterController { get; set; }

    /// <summary>
    /// Делегат, вызываемый при стрельбе игрока
    /// </summary>
    public Action OnPlayerShoots { get; set; }

    /// <summary>
    /// Данные об оружии игрока
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
