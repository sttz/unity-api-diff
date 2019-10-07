using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public interface IPlayableAsset
{
    public double duration { get; }
    public System.Collections.Generic.IEnumerable<Playables.PlayableBinding> outputs { get; }

    public Playables.Playable CreatePlayable(Playables.PlayableGraph graph, GameObject owner);

}

}
