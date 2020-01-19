using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct PlayableHandle : IEquatable<Playables.PlayableHandle>
{
    static public Playables.PlayableHandle Null { get; }

    public bool Equals(Playables.PlayableHandle other);
    public bool Equals(object p);
    public int GetHashCode();

}

}
