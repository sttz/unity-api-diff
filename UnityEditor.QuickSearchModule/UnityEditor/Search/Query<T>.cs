using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class Query<T> : UnityEditor.Search.Query<T, IEnumerable<T>>
{
    public bool returnPayloadIfEmpty { get; set; }

    public IEnumerable<T> Apply(IEnumerable<T> data);
    public bool Test(T element);

}

}
