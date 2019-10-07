using System;
using UnityEngine;

namespace UnityEngine
{

public class AsyncOperation : YieldInstruction
{
    public bool allowSceneActivation { get; set; }
    public bool isDone { get; }
    public int priority { get; set; }
    public float progress { get; }

    public event Action<AsyncOperation> completed;

    public AsyncOperation();

}

}
