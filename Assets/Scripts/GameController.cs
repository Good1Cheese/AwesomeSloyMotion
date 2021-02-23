using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    [SerializeField] float gameGravity;

    public float GameGravity { get => gameGravity; }
    public GameObject PlayerCamera { get; set; }
    public GameObject Player { get; set; }

    void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("There are more then 1 Instance of GameController!");
            return;
        }
        Instance = this;
    }
}
