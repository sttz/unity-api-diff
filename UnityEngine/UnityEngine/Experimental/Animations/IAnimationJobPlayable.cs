using System;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public interface IAnimationJobPlayable : Playables.IPlayable
{
    public T GetJobData();
    public void SetJobData(T jobData);

}

}
