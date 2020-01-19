using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Audio
{

public struct AudioClipPlayable : Playables.IPlayable, IEquatable<Audio.AudioClipPlayable>
{
    static public Audio.AudioClipPlayable Create(Playables.PlayableGraph graph, AudioClip clip, bool looping);

    public bool Equals(Audio.AudioClipPlayable other);
    public AudioClip GetClip();
    public Playables.PlayableHandle GetHandle();
    public bool GetLooped();
    public double GetPauseDelay();
    public double GetStartDelay();
    public bool IsChannelPlaying();
    public bool IsPlaying();
    public void Seek(double startTime, double startDelay);
    public void Seek(double startTime, double startDelay, double duration);
    public void SetClip(AudioClip value);
    public void SetLooped(bool value);

}

}
