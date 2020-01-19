using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public interface IAnimationWindowPostProcess
{
    public Playables.Playable PostProcessPlayableGraph(Playables.PlayableGraph graph, Playables.Playable inputPlayable);

}

}
