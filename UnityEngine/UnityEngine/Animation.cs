using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Animation : Behaviour, System.Collections.IEnumerable
{
    public bool animateOnlyIfVisible { get; set; }
    public bool animatePhysics { get; set; }
    public AnimationClip clip { get; set; }
    public AnimationCullingType cullingType { get; set; }
    public bool isPlaying { get; }
    public AnimationState this[string name] { get; }
    public Bounds localBounds { get; set; }
    public bool playAutomatically { get; set; }
    public WrapMode wrapMode { get; set; }

    public Animation();

    public void AddClip(AnimationClip clip, string newName);
    public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame);
    public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame);
    public void Blend(string animation);
    public void Blend(string animation, float targetWeight);
    public void Blend(string animation, float targetWeight, float fadeLength);
    public void CrossFade(string animation);
    public void CrossFade(string animation, float fadeLength);
    public void CrossFade(string animation, float fadeLength, PlayMode mode);
    public AnimationState CrossFadeQueued(string animation);
    public AnimationState CrossFadeQueued(string animation, float fadeLength);
    public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue);
    public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode);
    public AnimationClip GetClip(string name);
    public int GetClipCount();
    public System.Collections.IEnumerator GetEnumerator();
    public bool IsPlaying(string name);
    public bool Play();
    public bool Play(PlayMode mode);
    public bool Play(string animation);
    public bool Play(string animation, PlayMode mode);
    public bool Play(AnimationPlayMode mode);
    public bool Play(string animation, AnimationPlayMode mode);
    public AnimationState PlayQueued(string animation);
    public AnimationState PlayQueued(string animation, QueueMode queue);
    public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode);
    public void RemoveClip(AnimationClip clip);
    public void RemoveClip(string clipName);
    public void Rewind();
    public void Rewind(string name);
    public void Sample();
    public void Stop();
    public void Stop(string name);
    public void SyncLayer(int layer);

}

}
