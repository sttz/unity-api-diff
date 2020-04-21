using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public interface IAnimationJobPlayable : Playables.IPlayable
{
    public T GetJobData<T>();
    public void SetJobData<T>(T jobData);

}

}
