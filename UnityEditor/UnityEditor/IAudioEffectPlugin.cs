using System;
using UnityEngine;

namespace UnityEditor
{

public abstract class IAudioEffectPlugin
{
    protected IAudioEffectPlugin();

    public bool GetFloatBuffer(string name, out float data, int numsamples);
    public bool GetFloatParameter(string name, out float value);
    public bool GetFloatParameterInfo(string name, out float minRange, out float maxRange, out float defaultValue);
    public int GetSampleRate();
    public bool IsPluginEditableAndEnabled();
    public bool SetFloatParameter(string name, float value);

}

}