using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct ScriptPlayableOutput : Playables.IPlayableOutput
{
    static public Playables.ScriptPlayableOutput Null { get; }

    static public Playables.ScriptPlayableOutput Create(Playables.PlayableGraph graph, string name);

    public Playables.PlayableOutputHandle GetHandle();

}

}
