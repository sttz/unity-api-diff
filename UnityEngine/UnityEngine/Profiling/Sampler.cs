using System;
using UnityEngine;

namespace UnityEngine.Profiling
{

public class Sampler
{
    static public Profiling.Sampler Get(string name);
    static public int GetNames(System.Collections.Generic.List<string> names);

    public bool isValid { get; }
    public string name { get; }

    public Profiling.Recorder GetRecorder();

}

}
