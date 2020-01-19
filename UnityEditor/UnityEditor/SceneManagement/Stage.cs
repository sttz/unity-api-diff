using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public abstract class Stage : ScriptableObject
{
    public string assetPath { get; }
    public UnityEditor.SceneManagement.StageHandle stageHandle { get; }

    protected Stage();

    public T FindComponentOfType<T>();
    public T[] FindComponentsOfType<T>();
    public ulong GetCombinedSceneCullingMaskForCamera();
    protected void OnCloseStage();
    protected void OnDisable();
    protected void OnEnable();

}

}
