using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public sealed class DisposeSentinel
{
    static public void Clear(Unity.Collections.LowLevel.Unsafe.DisposeSentinel sentinel);
    static public void Create(out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle safety, out Unity.Collections.LowLevel.Unsafe.DisposeSentinel sentinel, int callSiteStackDepth, Unity.Collections.Allocator allocator);
    static public void Dispose(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle safety, Unity.Collections.LowLevel.Unsafe.DisposeSentinel sentinel);

}

}
