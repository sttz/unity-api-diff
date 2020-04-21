using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct PlayableOutputHandle : IEquatable<Playables.PlayableOutputHandle>
{
    static public Playables.PlayableOutputHandle Null { get; }

    public bool Equals(Playables.PlayableOutputHandle other);
    public bool Equals(object p);
    public int GetHashCode();

}

}
