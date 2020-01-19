using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.IO.LowLevel.Unsafe
{

public static class AsyncReadManager
{
    static public Unity.IO.LowLevel.Unsafe.ReadHandle Read(string filename, Unity.IO.LowLevel.Unsafe.ReadCommand readCmds, uint readCmdCount);

}

}
