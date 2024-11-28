using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgr : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadSceneAsync("LayerDesign", LoadSceneMode.Additive);
    }
    private async void Start()
    {
        await Task.Delay(500);
        await SceneManager.LoadSceneAsync("Doscent&Others", LoadSceneMode.Additive);
    }
}