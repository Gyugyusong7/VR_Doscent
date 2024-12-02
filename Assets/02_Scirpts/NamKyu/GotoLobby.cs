using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoLobby : MonoBehaviour
{
    public void ChangeToLobbyScene()
    {
        SceneManager.LoadScene("Lobby");
    }
}
