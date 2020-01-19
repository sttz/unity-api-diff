using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct ScriptPlayable<T> : Playables.IPlayable, IEquatable<Playables.ScriptPlayable<T>>
{
    static public Playables.ScriptPlayable<T> Null { get; }

    static public Playables.ScriptPlayable<T> Create(Playables.PlayableGraph graph, int inputCount = 0);
    static public Playables.ScriptPlayable<T> Create(Playables.PlayableGraph graph, T template, int inputCount = 0);

    public bool Equals(Playables.ScriptPlayable<T> other);
    public T GetBehaviour();
    public Playables.PlayableHandle GetHandle();

}

}
