using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Audio
{

public struct AudioPlayableOutput : Playables.IPlayableOutput
{
    static public Audio.AudioPlayableOutput Null { get; }

    static public Audio.AudioPlayableOutput Create(Playables.PlayableGraph graph, string name, AudioSource target);

    public bool GetEvaluateOnSeek();
    public Playables.PlayableOutputHandle GetHandle();
    public AudioSource GetTarget();
    public void SetEvaluateOnSeek(bool value);
    public void SetTarget(AudioSource value);

}

}
