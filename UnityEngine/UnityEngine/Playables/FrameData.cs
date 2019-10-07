using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct FrameData
{
    public float deltaTime { get; }
    public double effectiveParentDelay { get; }
    public float effectiveParentSpeed { get; }
    public Playables.PlayState effectivePlayState { get; }
    public float effectiveSpeed { get; }
    public float effectiveWeight { get; }
    public EvaluationType evaluationType { get; }
    public ulong frameId { get; }
    public Playables.PlayableOutput output { get; }
    public bool seekOccurred { get; }
    public bool timeHeld { get; }
    public bool timeLooped { get; }
    public float weight { get; }

    public enum EvaluationType
    {
        Evaluate = 0,
        Playback = 1,
    }

}

}
