using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Jobs
{

public interface IJobParallelForTransform
{
    public void Execute(int index, Jobs.TransformAccess transform);

}

}
