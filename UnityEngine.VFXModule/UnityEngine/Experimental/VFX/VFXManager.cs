using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.VFX
{

public static class VFXManager
{
    static public float fixedTimeStep { get; set; }
    static public float maxDeltaTime { get; set; }

    static public Experimental.VFX.VisualEffect[] GetComponents();
    static public Experimental.VFX.VFXCameraBufferTypes IsCameraBufferNeeded(Camera cam);
    static public void ProcessCamera(Camera cam);
    static public void SetCameraBuffer(Camera cam, Experimental.VFX.VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height);

}

}
