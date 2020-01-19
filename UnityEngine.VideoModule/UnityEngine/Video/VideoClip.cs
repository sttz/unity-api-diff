using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Video
{

public sealed class VideoClip : Object
{
    public ushort audioTrackCount { get; }
    public ulong frameCount { get; }
    public double frameRate { get; }
    public uint height { get; }
    public double length { get; }
    public string originalPath { get; }
    public uint pixelAspectRatioDenominator { get; }
    public uint pixelAspectRatioNumerator { get; }
    public bool sRGB { get; }
    public uint width { get; }

    public ushort GetAudioChannelCount(ushort audioTrackIdx);
    public string GetAudioLanguage(ushort audioTrackIdx);
    public uint GetAudioSampleRate(ushort audioTrackIdx);

}

}
