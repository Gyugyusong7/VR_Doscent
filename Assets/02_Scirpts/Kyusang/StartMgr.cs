using UnityEngine;

public class StartMgr : MonoBehaviour
{
    public void GameStart()
    {
        SceneMgr.LoadLobby();
    }
}
