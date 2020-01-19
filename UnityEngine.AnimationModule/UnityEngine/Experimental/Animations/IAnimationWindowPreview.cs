using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public interface IAnimationWindowPreview
{
    public Playables.Playable BuildPreviewGraph(Playables.PlayableGraph graph, Playables.Playable inputPlayable);
    public void StartPreview();
    public void StopPreview();
    public void UpdatePreviewGraph(Playables.PlayableGraph graph);

}

}
