using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public abstract class ScriptableRuntimeReflectionSystem : Experimental.Rendering.IScriptableRuntimeReflectionSystem, IDisposable
{
    protected ScriptableRuntimeReflectionSystem();

    protected void Dispose(bool disposing);
    public bool TickRealtimeProbes();

}

}
