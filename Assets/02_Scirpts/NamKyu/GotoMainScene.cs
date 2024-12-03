using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMainScene : MonoBehaviour
{
    public void ChangeToLobbyScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
