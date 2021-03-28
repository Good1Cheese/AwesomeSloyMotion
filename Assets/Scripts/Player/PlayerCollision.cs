using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] TimeSlower timeSlower;

    void Start()
    {
        timeSlower.ActivatePower();
        timeSlower.DeactivatePower();
    }

    // TODO: fix bag, when Player doesnt move with his parent object without code above
    // TODO: code below doesnt work

    void OnControllerColliderHit(ControllerColliderHit _hit)
    {
        var bulletController = _hit.collider.gameObject.GetComponent<CapsuleDestroyer>();

        bool hasColliderCapsuleMovementComponent = (bulletController != null);
        if (hasColliderCapsuleMovementComponent)
        {
            transform.SetParent(_hit.collider.transform);
        }
        else
        {
            transform.SetParent(null);
        }
    }
}