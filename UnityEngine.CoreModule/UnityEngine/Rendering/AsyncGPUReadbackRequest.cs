using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct AsyncGPUReadbackRequest
{
    public int depth { get; }
    public bool done { get; }
    public bool hasError { get; }
    public int height { get; }
    public int layerCount { get; }
    public int layerDataSize { get; }
    public int width { get; }

    public Unity.Collections.NativeArray<T> GetData<T>(int layer = 0);
    public void Update();
    public void WaitForCompletion();

}

}
