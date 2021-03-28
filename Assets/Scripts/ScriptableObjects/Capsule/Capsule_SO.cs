using UnityEngine;

[CreateAssetMenu(fileName = "New Capsule", menuName = "ScriptableObjects/Capsule")]
public class Capsule_SO : ScriptableObject
{
    [Tooltip("Multiplier of speed")]
    public float speedMultiplier;

    [Tooltip("Delay before destruction")]
    public float destroyDelay;

    [Tooltip("Distance after which capsule will destroyed")]
    public float flyDistance;

    [Tooltip("")]
    public Color secondaryDestroyColor;

    [Tooltip("Color while desctuction")]
    public Color destroyColor;

    [Tooltip("Spawns on destruction ob capsule")]
    public GameObject destroyEffect;
}
