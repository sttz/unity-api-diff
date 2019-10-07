using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class AudioSettings
{
    static public AudioSpeakerMode driverCapabilities { get; }
    static public AudioSpeakerMode driverCaps { get; }
    static public double dspTime { get; }
    static public int outputSampleRate { get; set; }
    static public AudioSpeakerMode speakerMode { get; set; }

    static public event AudioConfigurationChangeHandler OnAudioConfigurationChanged;

    static public AudioConfiguration GetConfiguration();
    static public void GetDSPBufferSize(out int bufferLength, out int numBuffers);
    static public string GetSpatializerPluginName();
    static public string[] GetSpatializerPluginNames();
    static public bool Reset(AudioConfiguration config);
    static public void SetDSPBufferSize(int bufferLength, int numBuffers);
    static public void SetSpatializerPluginName(string pluginName);

    public AudioSettings();

    public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);

}

}
