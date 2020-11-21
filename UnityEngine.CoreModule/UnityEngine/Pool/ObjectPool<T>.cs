using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Pool
{

public class ObjectPool<T> : IDisposable, Pool.IObjectPool<T>
{
    public int CountActive { get; }
    public int CountAll { get; private set; }
    public int CountInactive { get; }

    public ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000);

    public void Clear();
    public void Dispose();
    public T Get();
    public Pool.PooledObject<T> Get(out T v);
    public void Release(T element);

}

}
