using System;
using UnityEngine;

namespace UnityEditor
{

public class VideoImporterTargetSettings
{
    public UnityEditor.VideoEncodeAspectRatio aspectRatio;
    public UnityEditor.VideoBitrateMode bitrateMode;
    public UnityEditor.VideoCodec codec;
    public int customHeight;
    public int customWidth;
    public bool enableTranscoding;
    public UnityEditor.VideoResizeMode resizeMode;
    public UnityEditor.VideoSpatialQuality spatialQuality;

    public VideoImporterTargetSettings();

}

}
