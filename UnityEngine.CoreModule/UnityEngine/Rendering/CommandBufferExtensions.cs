using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public static class CommandBufferExtensions
{
    static public void SwitchIntoFastMemory(Rendering.CommandBuffer cmd, Rendering.RenderTargetIdentifier rid, Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
    static public void SwitchOutOfFastMemory(Rendering.CommandBuffer cmd, Rendering.RenderTargetIdentifier rid, bool copyContents);

}

}
