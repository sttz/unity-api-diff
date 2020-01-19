using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Profiling
{

public class Sampler
{
    static public Profiling.Sampler Get(string name);
    static public int GetNames(List<string> names);

    public bool isValid { get; }
    public string name { get; }

    public Profiling.Recorder GetRecorder();

}

}
