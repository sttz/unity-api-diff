using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public interface IPlayableAsset
{
    public double duration { get; }
    public IEnumerable<Playables.PlayableBinding> outputs { get; }

    public Playables.Playable CreatePlayable(Playables.PlayableGraph graph, GameObject owner);

}

}
