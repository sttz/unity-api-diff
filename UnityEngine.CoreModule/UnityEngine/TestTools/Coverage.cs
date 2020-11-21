using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.TestTools
{

public static class Coverage
{
    static public bool enabled { get; set; }

    static public TestTools.CoveredSequencePoint[] GetSequencePointsFor(System.Reflection.MethodBase method);
    static public TestTools.CoveredMethodStats GetStatsFor(System.Reflection.MethodBase method);
    static public TestTools.CoveredMethodStats[] GetStatsFor(System.Reflection.MethodBase[] methods);
    static public TestTools.CoveredMethodStats[] GetStatsFor(Type type);
    static public TestTools.CoveredMethodStats[] GetStatsForAllCoveredMethods();
    static public void ResetAll();
    static public void ResetFor(System.Reflection.MethodBase method);

}

}
