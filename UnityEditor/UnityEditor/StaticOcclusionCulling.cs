using System;
using UnityEngine;

namespace UnityEditor
{

public static class StaticOcclusionCulling
{
    static public float backfaceThreshold { get; set; }
    static public bool doesSceneHaveManualPortals { get; }
    static public bool isRunning { get; }
    static public float smallestHole { get; set; }
    static public float smallestOccluder { get; set; }
    static public int umbraDataSize { get; }

    static public void Cancel();
    static public void Clear();
    static public bool Compute();
    static public bool GenerateInBackground();
    static public void RemoveCacheFolder();
    static public void SetDefaultOcclusionBakeSettings();

}

}
