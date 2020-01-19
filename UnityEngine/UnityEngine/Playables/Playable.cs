using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct Playable : Playables.IPlayable, IEquatable<Playables.Playable>
{
    static public Playables.Playable Null { get; }

    static public Playables.Playable Create(Playables.PlayableGraph graph, int inputCount = 0);

    public bool Equals(Playables.Playable other);
    public Playables.PlayableHandle GetHandle();
    public Type GetPlayableType();
    public bool IsPlayableOfType<T>();

}

}
