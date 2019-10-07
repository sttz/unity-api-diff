using System;
using UnityEngine;

namespace UnityEngine.TestTools
{

public struct CoveredMethodStats
{
    public System.Reflection.MethodBase method;
    public int totalSequencePoints;
    public int uncoveredSequencePoints;

    public string ToString();

}

}
