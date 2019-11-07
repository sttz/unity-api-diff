using System;
using UnityEngine;

namespace UnityEngine
{

public class WaitForSecondsRealtime : CustomYieldInstruction
{
    public bool keepWaiting { get; }
    public float waitTime { get; set; }

    public WaitForSecondsRealtime(float time);

    public void Reset();

}

}
