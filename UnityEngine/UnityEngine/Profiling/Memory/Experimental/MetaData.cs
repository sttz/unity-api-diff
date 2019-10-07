using System;
using UnityEngine;

namespace UnityEngine.Profiling.Memory.Experimental
{

public class MetaData
{
    public string content;
    public string platform;

    public Texture2D screenshot { get; internal set; }

    public MetaData();

}

}
