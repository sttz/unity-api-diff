using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Jobs.LowLevel.Unsafe
{

public struct BatchQueryJob<CommandT, ResultT>
{
    public BatchQueryJob(Unity.Collections.NativeArray<CommandT> commands, Unity.Collections.NativeArray<ResultT> results);

}

}