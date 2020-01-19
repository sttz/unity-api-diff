using System;
using System.Collections;
using System.Collections.Generic;
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

    public static class Mobile
    {
        static public bool audioOutputStarted { get; }
        static public bool muteState { get; }
        static public bool stopAudioOutputOnMute { get; set; }

        static public event Action<bool> OnMuteStateChanged;

        static public void StartAudioOutput();
        static public void StopAudioOutput();

    }

}

}
