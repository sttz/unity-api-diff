using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct PlayableOutputHandle : IEquatable<Playables.PlayableOutputHandle>
{
    static public Playables.PlayableOutputHandle Null { get; }

    public bool Equals(object p);
    public bool Equals(Playables.PlayableOutputHandle other);
    public int GetHashCode();

}

}
