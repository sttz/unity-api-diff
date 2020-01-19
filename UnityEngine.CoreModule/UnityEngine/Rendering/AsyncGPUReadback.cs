using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public static class AsyncGPUReadback
{
    static public Rendering.AsyncGPUReadbackRequest Request(ComputeBuffer src, Action<Rendering.AsyncGPUReadbackRequest> callback = null);
    static public Rendering.AsyncGPUReadbackRequest Request(Texture src, int mipIndex = 0, Action<Rendering.AsyncGPUReadbackRequest> callback = null);
    static public Rendering.AsyncGPUReadbackRequest Request(Texture src, int mipIndex, TextureFormat dstFormat, Action<Rendering.AsyncGPUReadbackRequest> callback = null);
    static public Rendering.AsyncGPUReadbackRequest Request(ComputeBuffer src, int size, int offset, Action<Rendering.AsyncGPUReadbackRequest> callback = null);
    static public Rendering.AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<Rendering.AsyncGPUReadbackRequest> callback = null);
    static public Rendering.AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<Rendering.AsyncGPUReadbackRequest> callback = null);

}

}