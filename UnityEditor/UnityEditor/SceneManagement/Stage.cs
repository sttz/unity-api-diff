using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public abstract class Stage : ScriptableObject
{
    public string assetPath { get; }
    public UnityEditor.SceneManagement.StageHandle stageHandle { get; }

    protected Stage();

    public T FindComponentOfType();
    public T[] FindComponentsOfType();
    public ulong GetCombinedSceneCullingMaskForCamera();
    protected void OnCloseStage();
    protected void OnDisable();
    protected void OnEnable();

}

}
