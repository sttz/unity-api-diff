using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class AudioImporter : UnityEditor.AssetImporter
{
    public bool ambisonic { get; set; }
    public UnityEditor.AudioImporterChannels channels { get; set; }
    public int compressionBitrate { get; set; }
    public UnityEditor.AudioImporterSampleSettings defaultSampleSettings { get; set; }
    public bool forceToMono { get; set; }
    public bool hardware { get; set; }
    public bool loadInBackground { get; set; }
    public bool loopable { get; set; }
    public bool preloadAudioData { get; set; }
    public bool threeD { get; set; }

    public AudioImporter();

    public bool ClearSampleSettingOverride(string platform);
    public bool ContainsSampleSettingsOverride(string platform);
    public UnityEditor.AudioImporterSampleSettings GetOverrideSampleSettings(string platform);
    public bool SetOverrideSampleSettings(string platform, UnityEditor.AudioImporterSampleSettings settings);

}

}
