using System;
using UnityEngine;

namespace UnityEditor.Experimental.SceneManagement
{

public sealed class PrefabStage : UnityEditor.SceneManagement.PreviewSceneStage
{
    static public event Action<GameObject> prefabSaved;
    static public event Action<GameObject> prefabSaving;
    static public event Action<UnityEditor.Experimental.SceneManagement.PrefabStage> prefabStageClosing;
    static public event Action<UnityEditor.Experimental.SceneManagement.PrefabStage> prefabStageDirtied;
    static public event Action<UnityEditor.Experimental.SceneManagement.PrefabStage> prefabStageOpened;

    public string assetPath { get; }
    public Mode mode { get; }
    public GameObject openedFromInstanceObject { get; }
    public GameObject openedFromInstanceRoot { get; }
    public string prefabAssetPath { get; }
    public GameObject prefabContentsRoot { get; }

    public void ClearDirtiness();
    public ulong GetCombinedSceneCullingMaskForCamera();
    public bool IsPartOfPrefabContents(GameObject gameObject);
    protected void OnCloseStage();
    protected void OnDisable();
    protected void OnEnable();

    public enum Mode
    {
        InIsolation = 0,
        InContext = 1,
    }

}

}
