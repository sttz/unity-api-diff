using System;
using UnityEngine;

namespace UnityEditor.Media
{

public struct VideoTrackAttributes
{
    public UnityEditor.VideoBitrateMode bitRateMode;
    public UnityEditor.Media.MediaRational frameRate;
    public uint height;
    public bool includeAlpha;
    public uint width;

}

}
