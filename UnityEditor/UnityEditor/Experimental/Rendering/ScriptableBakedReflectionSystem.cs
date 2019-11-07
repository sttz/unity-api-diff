using System;
using UnityEngine;

namespace UnityEditor.Experimental.Rendering
{

public abstract class ScriptableBakedReflectionSystem : UnityEditor.Experimental.Rendering.IScriptableBakedReflectionSystem, IDisposable
{
    public int stageCount { get; }
    public Hash128[] stateHashes { get; protected set; }

    protected ScriptableBakedReflectionSystem(int stageCount);

    public bool BakeAllReflectionProbes();
    public void Cancel();
    public void Clear();
    protected void Dispose(bool disposing);
    public void SynchronizeReflectionProbes();
    public void Tick(UnityEditor.Experimental.Rendering.SceneStateHash sceneStateHash, UnityEditor.Experimental.Rendering.IScriptableBakedReflectionSystemStageNotifier handle);

}

}
