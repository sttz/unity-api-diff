using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.VFX
{

public abstract class VFXSpawnerCallbacks : ScriptableObject
{
    protected VFXSpawnerCallbacks();

    public void OnPlay(VFX.VFXSpawnerState state, VFX.VFXExpressionValues vfxValues, VFX.VisualEffect vfxComponent);
    public void OnStop(VFX.VFXSpawnerState state, VFX.VFXExpressionValues vfxValues, VFX.VisualEffect vfxComponent);
    public void OnUpdate(VFX.VFXSpawnerState state, VFX.VFXExpressionValues vfxValues, VFX.VisualEffect vfxComponent);

}

}
