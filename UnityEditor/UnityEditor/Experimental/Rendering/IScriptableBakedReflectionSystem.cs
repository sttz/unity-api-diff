using System;
using UnityEngine;

namespace UnityEditor.Experimental.Rendering
{

public interface IScriptableBakedReflectionSystem : IDisposable
{
    public int stageCount { get; }
    public Hash128[] stateHashes { get; }

    public bool BakeAllReflectionProbes();
    public void Cancel();
    public void Clear();
    public void SynchronizeReflectionProbes();
    public void Tick(UnityEditor.Experimental.Rendering.SceneStateHash sceneStateHash, UnityEditor.Experimental.Rendering.IScriptableBakedReflectionSystemStageNotifier handle);

}

}
