using UnityEngine;

public class EndgameUIManager : MonoBehaviour
{
    [SerializeField] GameObject EndgameUI;

    void Start()
    {
        MainLinks.Instance.EndGameUI = EndgameUI;
    }
}
