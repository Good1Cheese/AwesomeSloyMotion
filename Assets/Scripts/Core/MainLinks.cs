using System;
using UnityEngine;

/// <summary>
/// Contatins main links
/// </summary>
public class MainLinks : MonoBehaviour
{
    public static MainLinks Instance;

    [Tooltip("Force of Gravity")]
    [SerializeField] float gravityForce;
    public float GravityForce { get => gravityForce; }
    public GameObject Player { get; set; }
    public GameObject PlayerCamera { get; set; }
    public Capsule_SO Capsule_SO { get; set; }
    public GameObject EndGameUI { get; set; }
    public Action OnCapsuleDestruction { get; set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("There is more then 1 instance of MainLinks");
            return;
        }
    }

}
