using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Pool
{

public class LinkedPool<T> : IDisposable, Pool.IObjectPool<T>
{
    public int CountInactive { get; private set; }

    public LinkedPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int maxSize = 10000);

    public void Clear();
    public void Dispose();
    public T Get();
    public Pool.PooledObject<T> Get(out T v);
    public void Release(T item);

}

}
