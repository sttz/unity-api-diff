using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Audio
{

public class AudioMixerEffectPlugin : UnityEditor.IAudioEffectPlugin
{
    public AudioMixerEffectPlugin();

    public bool GetFloatBuffer(string name, out float data, int numsamples);
    public bool GetFloatParameter(string name, out float value);
    public bool GetFloatParameterInfo(string name, out float minRange, out float maxRange, out float defaultValue);
    public int GetSampleRate();
    public bool IsPluginEditableAndEnabled();
    public bool SetFloatParameter(string name, float value);

}

}
