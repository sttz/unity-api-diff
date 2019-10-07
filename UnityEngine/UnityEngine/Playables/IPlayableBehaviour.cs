using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public interface IPlayableBehaviour
{
    public void OnBehaviourPause(Playables.Playable playable, Playables.FrameData info);
    public void OnBehaviourPlay(Playables.Playable playable, Playables.FrameData info);
    public void OnGraphStart(Playables.Playable playable);
    public void OnGraphStop(Playables.Playable playable);
    public void OnPlayableCreate(Playables.Playable playable);
    public void OnPlayableDestroy(Playables.Playable playable);
    public void PrepareFrame(Playables.Playable playable, Playables.FrameData info);
    public void ProcessFrame(Playables.Playable playable, Playables.FrameData info, object playerData);

}

}
