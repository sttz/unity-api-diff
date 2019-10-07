using System;
using UnityEngine;

namespace UnityEngine.Jobs
{

public interface IJobParallelForTransform
{
    public void Execute(int index, Jobs.TransformAccess transform);

}

}
