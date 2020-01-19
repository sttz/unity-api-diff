using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public abstract class PreviewSceneStage : UnityEditor.SceneManagement.Stage
{
    public SceneManagement.Scene scene { get; protected set; }
    public UnityEditor.SceneManagement.StageHandle stageHandle { get; }

    protected PreviewSceneStage();

    protected void OnCloseStage();

}

}
