using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.Rendering
{

public interface IScriptableBakedReflectionSystemStageNotifier
{
    public void EnterStage(int stage, string progressMessage, float progress);
    public void ExitStage(int stage);
    public void SetIsDone(bool isDone);

}

}
