using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct PlayableHandle : IEquatable<Playables.PlayableHandle>
{
    static public Playables.PlayableHandle Null { get; }

    public bool Equals(object p);
    public bool Equals(Playables.PlayableHandle other);
    public int GetHashCode();

}

}
