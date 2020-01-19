using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Audio
{

public class AudioMixerSnapshot : Object, Internal.ISubAssetNotDuplicatable
{
    public Audio.AudioMixer audioMixer { get; }

    public void TransitionTo(float timeToReach);

}

}