using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class ProfilerFrameDataIterator : IDisposable
{
    public int depth { get; }
    public float durationMS { get; }
    public string extraTooltipInfo { get; }
    public float frameTimeMS { get; }
    public int group { get; }
    public int id { get; }
    public int instanceId { get; }
    public int maxDepth { get; }
    public string name { get; }
    public string path { get; }
    public int sampleId { get; }
    public float startTimeMS { get; }

    public ProfilerFrameDataIterator();

    public void Dispose();
    public double GetFrameStartS(int frame);
    public int GetGroupCount(int frame);
    public string GetGroupName();
    public int GetThreadCount(int frame);
    public string GetThreadName();
    public bool Next(bool enterChildren);
    public void SetRoot(int frame, int threadIdx);

}

}
