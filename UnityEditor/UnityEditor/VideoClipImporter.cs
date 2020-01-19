using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class VideoClipImporter : UnityEditor.AssetImporter
{
    public UnityEditor.VideoImporterTargetSettings defaultTargetSettings { get; set; }
    public UnityEditor.VideoDeinterlaceMode deinterlaceMode { get; set; }
    public bool flipHorizontal { get; set; }
    public bool flipVertical { get; set; }
    public int frameCount { get; }
    public double frameRate { get; }
    public bool importAudio { get; set; }
    public bool isPlayingPreview { get; }
    public bool keepAlpha { get; set; }
    public bool linearColor { get; set; }
    public ulong outputFileSize { get; }
    public int pixelAspectRatioDenominator { get; }
    public int pixelAspectRatioNumerator { get; }
    public float quality { get; set; }
    public ushort sourceAudioTrackCount { get; }
    public ulong sourceFileSize { get; }
    public bool sourceHasAlpha { get; }
    public bool transcodeSkipped { get; }
    public bool useLegacyImporter { get; set; }

    public VideoClipImporter();

    public void ClearTargetSettings(string platform);
    public bool Equals(UnityEditor.VideoClipImporter rhs);
    public Texture GetPreviewTexture();
    public int GetResizeHeight(UnityEditor.VideoResizeMode mode);
    public string GetResizeModeName(UnityEditor.VideoResizeMode mode);
    public int GetResizeWidth(UnityEditor.VideoResizeMode mode);
    public ushort GetSourceAudioChannelCount(ushort audioTrackIdx);
    public uint GetSourceAudioSampleRate(ushort audioTrackIdx);
    public UnityEditor.VideoImporterTargetSettings GetTargetSettings(string platform);
    public void PlayPreview();
    public void SetTargetSettings(string platform, UnityEditor.VideoImporterTargetSettings settings);
    public void StopPreview();

}

}
