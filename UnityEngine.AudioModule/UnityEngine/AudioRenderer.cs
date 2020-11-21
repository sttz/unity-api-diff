using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class AudioRenderer
{
    static public int GetSampleCountForCaptureFrame();
    static public bool Render(Unity.Collections.NativeArray<float> buffer);
    static public bool Start();
    static public bool Stop();

    public AudioRenderer();

}

}
