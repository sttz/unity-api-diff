using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public abstract class PlayableAsset : ScriptableObject, Playables.IPlayableAsset
{
    public double duration { get; }
    public System.Collections.Generic.IEnumerable<Playables.PlayableBinding> outputs { get; }

    protected PlayableAsset();

    public Playables.Playable CreatePlayable(Playables.PlayableGraph graph, GameObject owner);

}

}
