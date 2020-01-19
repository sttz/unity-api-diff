using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Playables
{

public struct TextureMixerPlayable : Playables.IPlayable, IEquatable<Experimental.Playables.TextureMixerPlayable>
{
    static public Experimental.Playables.TextureMixerPlayable Create(Playables.PlayableGraph graph);

    public bool Equals(Experimental.Playables.TextureMixerPlayable other);
    public Playables.PlayableHandle GetHandle();

}

}
