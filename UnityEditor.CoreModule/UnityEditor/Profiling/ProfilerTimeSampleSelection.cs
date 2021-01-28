using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling
{

public sealed class ProfilerTimeSampleSelection
{
    public long frameIndex { get; private set; }
    public System.Collections.ObjectModel.ReadOnlyCollection<string> markerNamePath { get; }
    public int markerPathDepth { get; private set; }
    public int rawSampleIndex { get; }
    public System.Collections.ObjectModel.ReadOnlyCollection<int> rawSampleIndices { get; }
    public string sampleDisplayName { get; private set; }
    public string threadGroupName { get; private set; }
    public ulong threadId { get; private set; }
    public string threadName { get; private set; }

    public ProfilerTimeSampleSelection(UnityEditor.Profiling.ProfilerTimeSampleSelection selection);
    public ProfilerTimeSampleSelection(long frameIndex, string threadGroupName, string threadName, ulong threadId, int rawSampleIndex, string sampleName = null);
    public ProfilerTimeSampleSelection(long frameIndex, string threadGroupName, string threadName, ulong threadId, IList<int> rawSampleIndices, string sampleName = null);

}

}
