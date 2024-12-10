using System.Threading.Tasks;
using UnityEngine;

public class StartMgr : MonoBehaviour
{
    private async void Start(){
        await Task.Delay(3000);

        SceneMgr.LoadLobby();
    }
    public void GameStart()
    {
        SceneMgr.LoadLobby();
    }
}
