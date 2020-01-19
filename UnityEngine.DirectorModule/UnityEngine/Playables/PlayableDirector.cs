using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public class PlayableDirector : Behaviour, IExposedPropertyTable
{
    public double duration { get; }
    public Playables.DirectorWrapMode extrapolationMode { get; set; }
    public double initialTime { get; set; }
    public Playables.PlayableAsset playableAsset { get; set; }
    public Playables.PlayableGraph playableGraph { get; }
    public bool playOnAwake { get; set; }
    public Playables.PlayState state { get; }
    public double time { get; set; }
    public Playables.DirectorUpdateMode timeUpdateMode { get; set; }

    public event Action<Playables.PlayableDirector> paused;
    public event Action<Playables.PlayableDirector> played;
    public event Action<Playables.PlayableDirector> stopped;

    public PlayableDirector();

    public void ClearGenericBinding(Object key);
    public void ClearReferenceValue(PropertyName id);
    public void DeferredEvaluate();
    public void Evaluate();
    public Object GetGenericBinding(Object key);
    public Object GetReferenceValue(PropertyName id, out bool idValid);
    public void Pause();
    public void Play();
    public void Play(Playables.PlayableAsset asset);
    public void Play(Playables.PlayableAsset asset, Playables.DirectorWrapMode mode);
    public void RebindPlayableGraphOutputs();
    public void RebuildGraph();
    public void Resume();
    public void SetGenericBinding(Object key, Object value);
    public void SetReferenceValue(PropertyName id, Object value);
    public void Stop();

}

}
