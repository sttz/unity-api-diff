using System;
using UnityEngine;

namespace UnityEngine
{

public static class HashUnsafeUtilities
{
    static public void ComputeHash128(void data, ulong dataSize, ulong hash1, ulong hash2);
    static public void ComputeHash128(void data, ulong dataSize, Hash128 hash);

}

}
