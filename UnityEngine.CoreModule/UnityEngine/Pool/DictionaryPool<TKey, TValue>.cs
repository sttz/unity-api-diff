using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Pool
{

public class DictionaryPool<TKey, TValue> : Pool.CollectionPool<Dictionary<TKey, TValue>, KeyValuePair<TKey, TValue>>
{
    public DictionaryPool();

}

}
