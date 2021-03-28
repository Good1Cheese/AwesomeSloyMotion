using UnityEngine;

public class EndgameInteraction : MonoBehaviour
{
    void OnTriggerEnter(Collider _other)
    {
        if (_other.gameObject == MainLinks.Instance.Player)
        {
            PauseGame();
        }
    }
        
    void PauseGame()
    {
        MainLinks.Instance.PlayerCamera.transform.SetParent(null);
        MainLinks.Instance.Player.SetActive(false);
        //TODO : Disable camera rotation script
        MainLinks.Instance.EndGameUI.SetActive(true);
    }
}
