using System;
using System.Collections;
using System.Collections.Generic;
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
