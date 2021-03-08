using UnityEngine;

public class EnemyInteractionProvider : MonoBehaviour, IInteractionProvider
{
    public void ProvideInteraction(GameObject hit)
    {
        EnemyInteraction enemyInteraction = hit.GetComponent<EnemyInteraction>();
        if (enemyInteraction != null)
        {
            enemyInteraction.Interact();
        }
    }

}
