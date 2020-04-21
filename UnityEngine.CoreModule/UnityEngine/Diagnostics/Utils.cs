using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Diagnostics
{

public static class Utils
{
    static public void ForceCrash(Diagnostics.ForcedCrashCategory crashCategory);
    static public void NativeAssert(string message);
    static public void NativeError(string message);
    static public void NativeWarning(string message);

}

}
