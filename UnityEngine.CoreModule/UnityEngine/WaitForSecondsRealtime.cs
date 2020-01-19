using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class WaitForSecondsRealtime : CustomYieldInstruction
{
    public bool keepWaiting { get; }
    public float waitTime { get; set; }

    public WaitForSecondsRealtime(float time);

}

}
