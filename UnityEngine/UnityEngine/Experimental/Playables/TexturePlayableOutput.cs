using System;
using UnityEngine;

namespace UnityEngine.Experimental.Playables
{

public struct TexturePlayableOutput : Playables.IPlayableOutput
{
    static public Experimental.Playables.TexturePlayableOutput Null { get; }

    static public Experimental.Playables.TexturePlayableOutput Create(Playables.PlayableGraph graph, string name, RenderTexture target);

    public Playables.PlayableOutputHandle GetHandle();
    public RenderTexture GetTarget();
    public void SetTarget(RenderTexture value);

}

}
