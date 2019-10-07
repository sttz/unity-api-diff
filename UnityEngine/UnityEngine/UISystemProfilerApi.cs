using System;
using UnityEngine;

namespace UnityEngine
{

public static class UISystemProfilerApi
{
    static public void AddMarker(string name, Object obj);
    static public void BeginSample(SampleType type);
    static public void EndSample(SampleType type);

    public enum SampleType
    {
        Layout = 0,
        Render = 1,
    }

}

}
