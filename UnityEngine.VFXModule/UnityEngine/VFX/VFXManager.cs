using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.VFX
{

public static class VFXManager
{
    static public float fixedTimeStep { get; set; }
    static public float maxDeltaTime { get; set; }

    static public VFX.VisualEffect[] GetComponents();
    static public VFX.VFXCameraBufferTypes IsCameraBufferNeeded(Camera cam);
    static public void PrepareCamera(Camera cam);
    static public void ProcessCamera(Camera cam);
    static public void ProcessCameraCommand(Camera cam, Rendering.CommandBuffer cmd);
    static public void SetCameraBuffer(Camera cam, VFX.VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height);

}

}
