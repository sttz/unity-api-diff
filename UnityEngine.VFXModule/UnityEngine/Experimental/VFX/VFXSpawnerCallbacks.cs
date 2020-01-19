using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.VFX
{

public abstract class VFXSpawnerCallbacks : ScriptableObject
{
    protected VFXSpawnerCallbacks();

    public void OnPlay(Experimental.VFX.VFXSpawnerState state, Experimental.VFX.VFXExpressionValues vfxValues, Experimental.VFX.VisualEffect vfxComponent);
    public void OnStop(Experimental.VFX.VFXSpawnerState state, Experimental.VFX.VFXExpressionValues vfxValues, Experimental.VFX.VisualEffect vfxComponent);
    public void OnUpdate(Experimental.VFX.VFXSpawnerState state, Experimental.VFX.VFXExpressionValues vfxValues, Experimental.VFX.VisualEffect vfxComponent);

}

}
