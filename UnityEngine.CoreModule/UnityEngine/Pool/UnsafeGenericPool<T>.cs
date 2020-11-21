using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Pool
{

public static class UnsafeGenericPool<T>
{
    static public T Get();
    static public Pool.PooledObject<T> Get(out T value);
    static public void Release(T toRelease);

}

}
