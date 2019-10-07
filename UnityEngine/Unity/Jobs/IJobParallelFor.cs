using System;
using UnityEngine;

namespace Unity.Jobs
{

public interface IJobParallelFor
{
    public void Execute(int index);

}

}
