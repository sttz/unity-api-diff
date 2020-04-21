using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.TestTools
{

public struct CoveredSequencePoint
{
    public uint column;
    public string filename;
    public uint hitCount;
    public uint ilOffset;
    public uint line;
    public System.Reflection.MethodBase method;

}

}
