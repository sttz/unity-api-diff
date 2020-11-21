using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Pool
{

public interface IObjectPool<T>
{
    public int CountInactive { get; }

    public void Clear();
    public T Get();
    public Pool.PooledObject<T> Get(out T v);
    public void Release(T element);

}

}
