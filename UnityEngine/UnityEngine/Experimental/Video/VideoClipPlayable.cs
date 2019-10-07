using System;
using UnityEngine;

namespace UnityEngine.Experimental.Video
{

public struct VideoClipPlayable : Playables.IPlayable, IEquatable<Experimental.Video.VideoClipPlayable>
{
    static public Experimental.Video.VideoClipPlayable Create(Playables.PlayableGraph graph, Video.VideoClip clip, bool looping);

    public bool Equals(Experimental.Video.VideoClipPlayable other);
    public Video.VideoClip GetClip();
    public Playables.PlayableHandle GetHandle();
    public bool GetLooped();
    public double GetPauseDelay();
    public double GetStartDelay();
    public bool IsPlaying();
    public void Seek(double startTime, double startDelay);
    public void Seek(double startTime, double startDelay, double duration);
    public void SetClip(Video.VideoClip value);
    public void SetLooped(bool value);

}

}
