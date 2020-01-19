using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Audio
{

public class AudioMixer : Object
{
    public Audio.AudioMixerGroup outputAudioMixerGroup { get; set; }
    public Audio.AudioMixerUpdateMode updateMode { get; set; }

    public bool ClearFloat(string name);
    public Audio.AudioMixerGroup[] FindMatchingGroups(string subPath);
    public Audio.AudioMixerSnapshot FindSnapshot(string name);
    public bool GetFloat(string name, out float value);
    public bool SetFloat(string name, float value);
    public void TransitionToSnapshots(Audio.AudioMixerSnapshot[] snapshots, float[] weights, float timeToReach);

}

}
