using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgr : MonoBehaviour
{
    public static Action OnExitLobby;
    public static Action OnEnterLayerDesign;

    private void Awake()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync(4, LoadSceneMode.Additive);
    }

    private void OnEnable()
    {
        OnExitLobby += ExitLobby;
        OnEnterLayerDesign += EnterLayerDesign;
    }

    private void OnDisable()
    {
        OnExitLobby -= ExitLobby;
        OnEnterLayerDesign -= EnterLayerDesign;
    }

    private void ExitLobby()
    {
        for (int i = 1; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.buildIndex == 2 && scene.isLoaded)
            {
                SceneManager.UnloadSceneAsync(scene);
                Debug.Log($"Unloading scene {scene.name} with build index {scene.buildIndex}");
                return;
            }
        }

        Debug.LogWarning("Lobby scene not found or already unloaded");
    }

    private void EnterLayerDesign()
    {
        bool sceneLoaded = false;

        for (int i = 1; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.buildIndex == 3)
            {
                sceneLoaded = true;
                break;
            }
        }

        if (!sceneLoaded)
        {
            Debug.Log("Layer Design scene not loaded, loading now");
            SceneManager.LoadScene(3, LoadSceneMode.Additive);
        }
    }

    // Optional: Debug method to log scene information
    private void DebugSceneInfo()
    {
        Debug.Log($"Total loaded scenes: {SceneManager.sceneCount}");
        for (int i = 1; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            Debug.Log($"Scene {i}: Name = {scene.name}, Build Index = {scene.buildIndex}, Is Loaded = {scene.isLoaded}");
        }
    }
    public static void LoadLobby()
    {
        SceneManager.LoadScene(1);
    }
}