using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Profiling
{

public sealed class Recorder
{
    static public Profiling.Recorder Get(string samplerName);

    public long elapsedNanoseconds { get; }
    public bool enabled { get; set; }
    public bool isValid { get; }
    public int sampleBlockCount { get; }

    public void CollectFromAllThreads();
    public void FilterToCurrentThread();

}

}
