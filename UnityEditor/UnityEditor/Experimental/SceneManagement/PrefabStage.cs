using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.SceneManagement
{

public class PrefabStage
{
    static public event Action<GameObject> prefabSaved;
    static public event Action<GameObject> prefabSaving;
    static public event Action<UnityEditor.Experimental.SceneManagement.PrefabStage> prefabStageClosing;
    static public event Action<UnityEditor.Experimental.SceneManagement.PrefabStage> prefabStageOpened;

    public string prefabAssetPath { get; }
    public GameObject prefabContentsRoot { get; }
    public SceneManagement.Scene scene { get; }
    public UnityEditor.SceneManagement.StageHandle stageHandle { get; }

    public void ClearDirtiness();
    public bool IsPartOfPrefabContents(GameObject gameObject);

}

}
