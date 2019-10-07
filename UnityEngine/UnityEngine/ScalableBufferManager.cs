using System;
using UnityEngine;

namespace UnityEngine
{

public static class ScalableBufferManager
{
    static public float heightScaleFactor { get; }
    static public float widthScaleFactor { get; }

    static public void ResizeBuffers(float widthScale, float heightScale);

}

}
