using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Pool
{

public class CollectionPool<TCollection, TItem>
{
    static public TCollection Get();
    static public Pool.PooledObject<TCollection> Get(out TCollection value);
    static public void Release(TCollection toRelease);

    public CollectionPool();

}

}
