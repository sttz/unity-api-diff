using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct PlayableOutput : Playables.IPlayableOutput, IEquatable<Playables.PlayableOutput>
{
    static public Playables.PlayableOutput Null { get; }

    public bool Equals(Playables.PlayableOutput other);
    public Playables.PlayableOutputHandle GetHandle();
    public Type GetPlayableOutputType();
    public bool IsPlayableOutputOfType();

}

}
