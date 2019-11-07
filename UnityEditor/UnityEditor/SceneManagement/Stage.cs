using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public abstract class Stage : ScriptableObject
{
    public string assetPath { get; }
    public UnityEditor.SceneManagement.StageHandle stageHandle { get; }

    protected Stage();

    protected void CloseStage();
    protected void OnDisable();
    protected void OnEnable();

}

}
