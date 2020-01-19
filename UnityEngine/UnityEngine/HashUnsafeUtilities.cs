using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class HashUnsafeUtilities
{
    static public void ComputeHash128(void data, ulong dataSize, Hash128 hash);
    static public void ComputeHash128(void data, ulong dataSize, ulong hash1, ulong hash2);

}

}
