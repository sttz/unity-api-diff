using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public abstract class PlayableBehaviour : Playables.IPlayableBehaviour, ICloneable
{
    public PlayableBehaviour();

    public object Clone();
    public void OnBehaviourDelay(Playables.Playable playable, Playables.FrameData info);
    public void OnBehaviourPause(Playables.Playable playable, Playables.FrameData info);
    public void OnBehaviourPlay(Playables.Playable playable, Playables.FrameData info);
    public void OnGraphStart(Playables.Playable playable);
    public void OnGraphStop(Playables.Playable playable);
    public void OnPlayableCreate(Playables.Playable playable);
    public void OnPlayableDestroy(Playables.Playable playable);
    public void PrepareData(Playables.Playable playable, Playables.FrameData info);
    public void PrepareFrame(Playables.Playable playable, Playables.FrameData info);
    public void ProcessFrame(Playables.Playable playable, Playables.FrameData info, object playerData);

}

}
