using UnityEngine;

/// <summary>
/// SO, which contains info about capsule
/// </summary>
[CreateAssetMenu(fileName = "New CapsuleSpawner", menuName = "ScriptableObjects/CapsuleSpawner")]
public class CapsuleSpawner_SO : ScriptableObject
{
    [Tooltip("Delay after spawn")]
    public float delayAfterShot;

    [Tooltip("Multiplier radius of spawn")]
    public float spawnRadiusMultiplier;

    public Vector3 spawnSphereOffset;

    public GameObject capsulePrefab;

}
