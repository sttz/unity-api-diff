using System;
using UnityEngine;

namespace UnityEngine.SceneManagement
{

public class SceneManager
{
    static public int sceneCount { get; }
    static public int sceneCountInBuildSettings { get; }

    static public event Events.UnityAction<SceneManagement.Scene, SceneManagement.Scene> activeSceneChanged;
    static public event Events.UnityAction<SceneManagement.Scene, SceneManagement.LoadSceneMode> sceneLoaded;
    static public event Events.UnityAction<SceneManagement.Scene> sceneUnloaded;

    static public SceneManagement.Scene CreateScene(string sceneName, SceneManagement.CreateSceneParameters parameters);
    static public SceneManagement.Scene CreateScene(string sceneName);
    static public SceneManagement.Scene GetActiveScene();
    static public SceneManagement.Scene[] GetAllScenes();
    static public SceneManagement.Scene GetSceneAt(int index);
    static public SceneManagement.Scene GetSceneByBuildIndex(int buildIndex);
    static public SceneManagement.Scene GetSceneByName(string name);
    static public SceneManagement.Scene GetSceneByPath(string scenePath);
    static public void LoadScene(string sceneName, SceneManagement.LoadSceneMode mode);
    static public void LoadScene(string sceneName);
    static public SceneManagement.Scene LoadScene(string sceneName, SceneManagement.LoadSceneParameters parameters);
    static public void LoadScene(int sceneBuildIndex, SceneManagement.LoadSceneMode mode);
    static public void LoadScene(int sceneBuildIndex);
    static public SceneManagement.Scene LoadScene(int sceneBuildIndex, SceneManagement.LoadSceneParameters parameters);
    static public AsyncOperation LoadSceneAsync(int sceneBuildIndex, SceneManagement.LoadSceneMode mode);
    static public AsyncOperation LoadSceneAsync(int sceneBuildIndex);
    static public AsyncOperation LoadSceneAsync(int sceneBuildIndex, SceneManagement.LoadSceneParameters parameters);
    static public AsyncOperation LoadSceneAsync(string sceneName, SceneManagement.LoadSceneMode mode);
    static public AsyncOperation LoadSceneAsync(string sceneName);
    static public AsyncOperation LoadSceneAsync(string sceneName, SceneManagement.LoadSceneParameters parameters);
    static public void MergeScenes(SceneManagement.Scene sourceScene, SceneManagement.Scene destinationScene);
    static public void MoveGameObjectToScene(GameObject go, SceneManagement.Scene scene);
    static public bool SetActiveScene(SceneManagement.Scene scene);
    static public bool UnloadScene(SceneManagement.Scene scene);
    static public bool UnloadScene(int sceneBuildIndex);
    static public bool UnloadScene(string sceneName);
    static public AsyncOperation UnloadSceneAsync(int sceneBuildIndex);
    static public AsyncOperation UnloadSceneAsync(string sceneName);
    static public AsyncOperation UnloadSceneAsync(SceneManagement.Scene scene);
    static public AsyncOperation UnloadSceneAsync(int sceneBuildIndex, SceneManagement.UnloadSceneOptions options);
    static public AsyncOperation UnloadSceneAsync(string sceneName, SceneManagement.UnloadSceneOptions options);
    static public AsyncOperation UnloadSceneAsync(SceneManagement.Scene scene, SceneManagement.UnloadSceneOptions options);

    public SceneManager();

}

}
