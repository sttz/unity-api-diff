using System;
using UnityEngine;

namespace UnityEngine.Experimental.Audio
{

public class AudioSampleProvider : IDisposable
{
    static public ConsumeSampleFramesNativeFunction consumeSampleFramesNativeFunction { get; }

    public uint availableSampleFrameCount { get; }
    public ushort channelCount { get; private set; }
    public bool enableSampleFramesAvailableEvents { get; set; }
    public bool enableSilencePadding { get; set; }
    public uint freeSampleFrameCount { get; }
    public uint freeSampleFrameCountLowThreshold { get; set; }
    public uint id { get; private set; }
    public uint maxSampleFrameCount { get; }
    public Object owner { get; private set; }
    public uint sampleRate { get; private set; }
    public ushort trackIndex { get; private set; }
    public bool valid { get; }

    public event SampleFramesHandler sampleFramesAvailable;
    public event SampleFramesHandler sampleFramesOverflow;

    public void ClearSampleFramesAvailableNativeHandler();
    public void ClearSampleFramesOverflowNativeHandler();
    public uint ConsumeSampleFrames(Unity.Collections.NativeArray<float> sampleFrames);
    public void Dispose();
    public void SetSampleFramesAvailableNativeHandler(SampleFramesEventNativeFunction handler, IntPtr userData);
    public void SetSampleFramesOverflowNativeHandler(SampleFramesEventNativeFunction handler, IntPtr userData);

    public delegate uint ConsumeSampleFramesNativeFunction(uint providerId, IntPtr interleavedSampleFrames, uint sampleFrameCount);

    public delegate void SampleFramesHandler(Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount);

    public delegate void SampleFramesEventNativeFunction(IntPtr userData, uint providerId, uint sampleFrameCount);

}

}
