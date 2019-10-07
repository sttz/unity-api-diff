using System;
using UnityEngine;

namespace UnityEngine
{

public class AnimationCurve : IEquatable<AnimationCurve>
{
    static public AnimationCurve Constant(float timeStart, float timeEnd, float value);
    static public AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd);
    static public AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd);

    public Keyframe this[int index] { get; }
    public Keyframe[] keys { get; set; }
    public int length { get; }
    public WrapMode postWrapMode { get; set; }
    public WrapMode preWrapMode { get; set; }

    public AnimationCurve(Keyframe[] keys);
    public AnimationCurve();

    public int AddKey(float time, float value);
    public int AddKey(Keyframe key);
    public bool Equals(object o);
    public bool Equals(AnimationCurve other);
    public float Evaluate(float time);
    public int GetHashCode();
    public int MoveKey(int index, Keyframe key);
    public void RemoveKey(int index);
    public void SmoothTangents(int index, float weight);

}

}
